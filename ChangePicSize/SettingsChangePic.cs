using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangePicSize
{
    public class SettingsChangePic
    {
        public int Resolution { get; set; }
        public int Quality { get; set; }
        public string FileType { get; set; }
        public bool Rotate90Right { get; set; }
        public string SavePath { get; set; }

    }
}
