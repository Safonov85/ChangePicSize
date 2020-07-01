using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangePicSize
{
    public partial class Form1 : Form
    {
        int item = 1;
        List<Image> pictureList = new List<Image>();
        string pathSave;
        Point Large = new Point(1280, 1024);

        public Form1()
        {
            InitializeComponent();
            ResizeLevelCombobox.SelectedItem = 1;
            ResizeToLabel.Text = "Resize To: " + Large.X +" x " + Large.Y;


            QualityLabel.Visible = false;
            ResizeLevelCombobox.Visible = false;
            QualityTextBox.Visible = false;
        }

        private void LoadPicButton_Click(object sender, EventArgs e)
        {
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
                    if(dialog.FileNames.Length > 100)
                    {
                        MessageBox.Show("You have too many files selected. The maximum file amount is 100");
                        return;
                    }
                    if(pictureList.Count > 0)
                    {
                        pictureList.Clear();
                    }
                    pathSave = Path.GetDirectoryName(dialog.FileName);
                    int item = 0;

                    // ACTUAL FILES ADDED TO IMAGE LIST
                    foreach (String file in dialog.FileNames)
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
                Console.WriteLine("done");
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

        private void FilterFiles(OpenFileDialog dialog)
        {
            //dialog.Filter =
            //"Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
            //"All files (*.*)|*.*";
        }

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

                int count = 0;

                //ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);
                //System.Drawing.Imaging.Encoder myEncoder =
                //    System.Drawing.Imaging.Encoder.Quality;
                //EncoderParameters myEncoderParameters = new EncoderParameters(1);

                //EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, QualityTextBox.Text);
                //myEncoderParameters.Param[0] = myEncoderParameter;

                this.Text = "Re-size Picture (CONVERTING)";

                // SAVING resized images to new 'mindre' folder !!!!!!!!!!!!!!
                foreach (var picture in pictureList)
                {
                    Image newImage;
                    ResizePicture resizePic = new ResizePicture();
                    newImage = resizePic.ResizeImage(picture, Large.X, Large.Y);
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
                    PicturesListbox.Items[count] = PicturesListbox.Items[count] + " ✔";
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
            MessageBox.Show("Made by Mikhail Safonov. The maker of this app bears no responsibility for any damage that the use of this software may cause.");
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        private void ClearListButton_Click(object sender, EventArgs e)
        {
            pictureList.Clear();
            PicturesListbox.Items.Clear();
            //pictureList = null;

            int ident = GC.GetGeneration(pictureList);
            GC.Collect(ident, GCCollectionMode.Forced);
            
        }
    }
}
