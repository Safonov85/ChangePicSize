using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangePicSize
{
    public class ResizePicture
    {
        private bool rotateFlip = false;


        public Bitmap ResizeImage(Image image, int width, int height, bool rotateRight)
        {
            //if(image.Width < image.Height)
            //{
            //    image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            //    rotateFlip = true;
            //}

            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            //if(rotateFlip == true)
            //{
            //    destImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
            //    rotateFlip = false;
            //}

            if(rotateRight == true)
            {
                destImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

            return destImage;
        }
    }
}
