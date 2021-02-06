using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChangePicSize.Properties;

namespace ChangePicSize
{
    public partial class ChangePicMain : Form
    {
        int item = 1;
        List<Image> pictureList = new List<Image>();
        Dictionary<Image, string> pictureDict = new Dictionary<Image, string>();
        string pathSave;
        Point Large = new Point(1280, 1024);
        Point ratio1x1Large = new Point(1280, 1280);
        Point LargeCorrectAspectRatio;
        System.Int32 processComplete = 0;
        float getPercent;

        private bool filesProccessed = false;
        
        BackgroundWorker bgWorker = new BackgroundWorker();

        public ChangePicMain()
        {
            InitializeComponent();
            ResizeLevelCombobox.SelectedItem = 1;
            ResizeToLabel.Text = "Resize To: " + Large.X;


            QualityLabel.Visible = false;
            ResizeLevelCombobox.Visible = false;
            QualityTextBox.Visible = false;
            CancelButton.Visible = false;
            //DropSignLabel.Text = "";

            // Settings Load
            rotateRightCheckBox.Checked = Settings.Default.Rotate90Right;
        }
        
        // Manual loading process
        private void LoadPicButton_Click(object sender, EventArgs e)
        {
            if(PicturesListbox.Items.Count > 0)
            {
                MessageBox.Show("List contains pictures already. CLEAR LIST. Then try again.");
                return;
            }

            if(pictureList == null)
            {
                pictureList = new List<Image>();
            }

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.jpg;)|*.jpg;";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            dialog.Multiselect = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                try
                {
                        if (dialog.FileNames.Length > 100)
                        {
                            MessageBox.Show("You have too many files selected. The maximum file amount is 100");
                            return;
                        }
                        if (pictureList.Count > 0)
                        {
                            pictureList.Clear();
                        }
                        pathSave = Path.GetDirectoryName(dialog.FileName);
                        int item = 0;

                    
                        // ACTUAL FILES ADDED TO IMAGE LIST
                        foreach (var file in dialog.FileNames)
                        {
                            pictureList.Add(Image.FromFile(dialog.FileNames[item]));
                            //pictureList.Add()
                            item++;
                        }

                        item = 0;

                        // Just names added to listBox (simple strings)
                        foreach (String file in dialog.SafeFileNames)
                        {
                            PicturesListbox.Items.Add(dialog.SafeFileNames[item]);
                            item++;
                        }
                }
                catch (Exception expt)
                {
                    MessageBox.Show("An error occured: " + expt.Message);
                }
            }

            //if (dialog.ShowDialog() == DialogResult.OK)
            //{
            //    try
            //    {
            //        int item = 0;
            //        foreach (String file in dialog.SafeFileNames)
            //        {
            //            PicturesListbox.Items.Add(dialog.SafeFileNames[item] + "✔");
            //            item++;
            //        }
            //    }
            //    catch(Exception expt)
            //    {
            //        MessageBox.Show("An error occured: " + expt.Message);
            //    }

            //}
            //item++;
            //PicturesListbox.Items.Add("Item num" + item);

        }
        
        // Manual loading process
        void LoadImagesIntoList(OpenFileDialog dialog, int item)
        {

            // ACTUAL FILES ADDED TO IMAGE LIST
            foreach (var file in dialog.FileNames)
            {
                pictureList.Add(Image.FromFile(dialog.FileNames[item]));
                //pictureList.Add()
                item++;
            }
        }

        private void FilterFiles(OpenFileDialog dialog)
        {
            //dialog.Filter =
            //"Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
            //"All files (*.*)|*.*";
        }
        
        // Manual loading process
        private void ResizePicturesButton_Click(object sender, EventArgs e)
        {
            if(pictureList.Count == 0)
            {
                MessageBox.Show("No files loaded in the list");
                return;
            }

            try
            {
                if (!Directory.Exists(pathSave + "\\mindre"))
                {
                    Directory.CreateDirectory(pathSave + "\\mindre");
                }

                if (Directory.GetFiles(pathSave + "\\mindre").Length > 0)
                {
                    //MessageBox.Show("Save folder contains files. It will overwrite them. Do you want to continue?");

                    DialogResult dialogYesNo = MessageBox.Show("Save folder contains files. It will overwrite them. Do you want to continue?",
                            "Important Question",
                            MessageBoxButtons.YesNo);
                    if (dialogYesNo == DialogResult.No)
                    {
                        return;
                    }
                    
                }

                int count = 1;

                this.Text = "Re-size Picture (CONVERTING)";

                // SAVING resized images to new 'mindre' folder !!!!!!!!!!!!!!
                foreach (var picture in pictureList)
                {
                    Image newImage;
                    ResizePicture resizePic = new ResizePicture();

                    if(picture.Width == picture.Height)
                    {
                        newImage = resizePic.ResizeImage(picture, ratio1x1Large.X, ratio1x1Large.Y, rotateRightCheckBox.Checked);

                    }
                    else
                    {
                        newImage = resizePic.ResizeImage(picture, Large.X, Large.Y, rotateRightCheckBox.Checked);
                    }

                    string pathExists = pathSave + "\\mindre\\newpic" + count + ".jpg";

                    //if(pathExists != "blah")
                    //{
                    //    MessageBox.Show("blah is not the path");
                    //    return;
                    //}

                    //if (Directory.Exists(pathExists) != true)
                    //{
                    //    MessageBox.Show("The file with the same name exists. Operation will end. Remove the file and try again(restart application recommended). File: " + "newpic" + count + ".jpg");
                    //    return;
                    //}

                    newImage.Save(pathSave + "\\mindre\\newpic" + count + ".jpg", ImageFormat.Jpeg);
                    newImage.Dispose();
                    PicturesListbox.Items[count -1] = PicturesListbox.Items[count -1] + " ✔";
                    count++;
                }

                this.Text = "Re-size Picture";


            }

            catch(Exception expt)
            {
                MessageBox.Show(expt.Message);
            }
}

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            // DISCLAIMER 
            MessageBox.Show("Made by Mikhail Safonov 2020. The maker of this app bears no responsibility for any damage that the use of this software may cause.");
        }

        private void ClearListButton_Click(object sender, EventArgs e)
        {
            pictureList.Clear();
            PicturesListbox.Items.Clear();
            //pictureList = null;

            int ident = GC.GetGeneration(pictureList);
            GC.Collect(ident, GCCollectionMode.Forced);
            
        }

        private void DropSignLabel_Click(object sender, EventArgs e)
        {

        }
        
        private void ChangePicDragNdrop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }


        // Main Async Process of Load And Convert
        private async void ChangePicDragNdrop_DragDrop(object sender, DragEventArgs e)
        {
            if (filesProccessed == false)
            {
                filesProccessed = true;

                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);


                if (pictureDict.Count > 0)
                {
                    //pictureList.Clear();
                    pictureDict.Clear();
                }

                pathSave = Path.GetDirectoryName(files[0]);

                //if (Directory.Exists(pathSave + "\\mindre"))
                //{
                //    DialogResult dialogYesNo = MessageBox.Show("Save folder contains files. It will overwrite them. Do you want to continue?",
                //                "Important Question",
                //                MessageBoxButtons.YesNo);
                //    if (dialogYesNo == DialogResult.No)
                //    {
                //        return;
                //    }
                //}

                LiveUpdateProgressBar.Visible = true;
                ProgressLabel.Visible = true;
                DropSignLabel.ForeColor = Color.IndianRed;

                ProgressLabel.Text = "Loading pictures...";


                await LoadfilesAsync(files);

                LiveUpdateProgressBar.Value = 50;

                ProgressLabel.Text = "Converting pictures...";

                await ConvertFilesAsync();

                ProgressLabel.Text = "Done";
                DropSignLabel.ForeColor = SystemColors.ButtonFace;
                Thread.Sleep(1000);
                ProgressLabel.Visible = false;
                LiveUpdateProgressBar.Visible = false;
                LiveUpdateProgressBar.Value = 0;
                //ClearListFromMemory();

                // Removes Usage From RAM !!!!
                ClearDictFromMemory();
                filesProccessed = false;
            }
        }

        void ClearListFromMemory()
        {
            pictureList.Clear();

            int ident = GC.GetGeneration(pictureList);
            GC.Collect(ident, GCCollectionMode.Forced);
        }

        void ClearDictFromMemory()
        {
            pictureDict.Clear();

            int ident = GC.GetGeneration(pictureDict);
            GC.Collect(ident, GCCollectionMode.Forced);
        }

        // LOADING PICTURE FILES
        // Needs limit on amout files loaded (WIP) 
        public async Task LoadfilesAsync(string[] files)
        {
            // IProgress<LiveReport> progress // parameter

            await Task.Run(() =>
            {

            try
            {
                processComplete = 0;
                getPercent = (100f / (float)files.Length) / 2;

                // ACTUAL FILES ADDED TO IMAGE LIST
                foreach (var file in files)
                {
                    //pictureList.Add(Image.FromFile(file));
                    pictureDict.Add(Image.FromFile(file), file);

                        processComplete += (int)getPercent;

                        LiveUpdateProgressBar.Invoke((Action)(() => LiveUpdateProgressBar.Value = processComplete));
                    }

                    processComplete = 50;
                    
                }
                catch (Exception expt)
                {
                    MessageBox.Show("An error occured: " + expt.Message + ". Some files might be corrupt, or there is an issue with loading picture(s).");
                }
            });

        }

        // CONVERTING PICTURE FILES
        public async Task ConvertFilesAsync()
        {
            await Task.Run(() =>
            {

                try
                {
                    int count = 1;
                    string newPathFolder = "\\mindre\\";

                    if (!Directory.Exists(pathSave + "\\mindre\\"))
                    {
                        Directory.CreateDirectory(pathSave + "\\mindre\\");
                    }
                    else
                    {
                        if(!Directory.Exists(pathSave + "\\mindre1\\"))
                        {
                            Directory.CreateDirectory(pathSave + "\\mindre1\\");
                            newPathFolder = "\\mindre1\\";
                        }
                        else
                        {
                            if (!Directory.Exists(pathSave + "\\mindre2\\"))
                            {
                                Directory.CreateDirectory(pathSave + "\\mindre2\\");
                                newPathFolder = "\\mindre2\\";
                            }
                            else
                            {
                                if (!Directory.Exists(pathSave + "\\mindre3\\"))
                                {
                                    Directory.CreateDirectory(pathSave + "\\mindre3\\");
                                    newPathFolder = "\\mindre3\\";
                                }
                                else
                                {
                                    MessageBox.Show("You have reached the maximum amount of folders to create in your designated path. Please move or remove them and try again.");
                                    return;
                                }
                            }
                        }
                    }
                    //else
                    //{

                    //    Directory.CreateDirectory(pathSave + "\\mindre" + 1.ToString());

                    //}

                    // Kills 'Task' process because Label is outside of task preformance(part of GUI)
                    //ProgressLabel.Text = "Converting...";

                    //    --- List (Image) ---
                    //foreach (var picture in pictureList)
                    //{
                    //    Image newImage;
                    //    ResizePicture resizePic = new ResizePicture();
                    //    LargeCorrectAspectRatio.X = GetProperScaleRatio.ScaleDownRightRatio(picture.Width, picture.Height).X;
                    //    LargeCorrectAspectRatio.Y = GetProperScaleRatio.ScaleDownRightRatio(picture.Width, picture.Height).Y;


                    //    newImage = resizePic.ResizeImage(picture, LargeCorrectAspectRatio.X, LargeCorrectAspectRatio.Y, rotateRightCheckBox.Checked);

                    //    newImage.Save(pathSave + "\\mindre\\newPic" + count + ".jpg", ImageFormat.Jpeg);
                    //    newImage.Dispose();

                    //    processComplete += (int)getPercent;

                    //    if(processComplete < 100)
                    //    {
                    //        LiveUpdateProgressBar.Invoke((Action)(() => LiveUpdateProgressBar.Value = processComplete));
                    //    }

                    //    count++;
                    //}


                    //  --- Dictionary (Image and string) ---

                    foreach (var picture in pictureDict)
                    {
                        Image newImage;
                        ResizePicture resizePic = new ResizePicture();
                        LargeCorrectAspectRatio.X = GetProperScaleRatio.ScaleDownRightRatio(picture.Key.Width, picture.Key.Height).X;
                        LargeCorrectAspectRatio.Y = GetProperScaleRatio.ScaleDownRightRatio(picture.Key.Width, picture.Key.Height).Y;


                        newImage = resizePic.ResizeImage(picture.Key, LargeCorrectAspectRatio.X, LargeCorrectAspectRatio.Y, rotateRightCheckBox.Checked);

                        string fileName = Path.GetFileNameWithoutExtension(picture.Value);

                        newImage.Save(pathSave + newPathFolder + fileName + "_m.jpg", ImageFormat.Jpeg);
                        newImage.Dispose();

                        processComplete += (int)getPercent;

                        if (processComplete < 100)
                        {
                            LiveUpdateProgressBar.Invoke((Action)(() => LiveUpdateProgressBar.Value = processComplete));
                        }

                        count++;
                    }

                    LiveUpdateProgressBar.Invoke((Action)(() => LiveUpdateProgressBar.Value = 100));
                }
                catch (Exception expt)
                {
                    MessageBox.Show("An error occured: " + expt.Message + " There is an issue with converting picture(s).");
                }
            });
        }

        private void ResSettingsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void QualitySettingsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PathSettingsTextBox_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("yes type");
        }
    }
}
