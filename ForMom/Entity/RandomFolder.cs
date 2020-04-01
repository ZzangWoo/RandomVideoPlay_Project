using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class RandomFolder
    {
        public string folderPath { get; set; }
        public string folderName { get; set; }
        //public int videoCount { get; set; }

        public RandomFolder(string folderPath, string folderName)
        {
            this.folderPath = folderPath;
            this.folderName = folderName;
            //this.videoCount = videoCount;
        }
    }
}
