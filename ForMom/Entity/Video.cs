using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Video
    {
        public int videoNum { get; set; }
        public string videoPath { get; set; }
        public string videoName { get; set; }

        public Video(int videoNum, string videoPath, string videoName)
        {
            this.videoNum = videoNum;
            this.videoPath = videoPath;
            this.videoName = videoName;
        }
    }
}
