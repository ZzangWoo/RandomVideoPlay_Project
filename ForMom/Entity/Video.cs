using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Video
    {
        public string videoPath { get; set; }
        public string videoName { get; set; }

        public Video(string videoPath, string videoName)
        {
            this.videoPath = videoPath;
            this.videoName = videoName;
        }
    }
}
