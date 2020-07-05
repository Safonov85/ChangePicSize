using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangePicSize
{
    public class GetProperScaleRatio
    {

        public static Point ScaleDownRightRatio(int widhtOriginal, int heightOriginal)
        {
            float scale;
            Point pointScaled = new Point();
            scale = ((float)1280f / (float)widhtOriginal);

            pointScaled.X = (int)(scale * widhtOriginal);
            pointScaled.Y = (int)(scale * heightOriginal);

            return pointScaled;
        }
    }
}
