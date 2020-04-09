using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeLog
{
    public class MainLog
    {

        private string logPath;

        #region # Constructor

        /// <summary>
        /// 생성자
        /// 로그 경로 설정
        /// </summary>
        /// <param name="logPath"></param>
        public MainLog(string logPath)
        {
            this.logPath = logPath;
        }

        #endregion

        #region # Public Method

        /// <summary>
        /// 리스트에 대한 정보 저장 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="logName"></param>
        public void SaveListLog(List<RandomFolder> randomFolders, string logName)
        {
            using (StreamWriter streamWriter = new StreamWriter(logPath + logName, false, Encoding.UTF8))
            {
                foreach (var randomFolder in randomFolders)
                {
                    //streamWriter.WriteLine(randomFolder.folderPath + "\t" + randomFolder.folderName);
                    streamWriter.WriteLine("{0},{1}", randomFolder.folderPath, randomFolder.folderName);
                }
            }
        }


        public void WriteLog(string message)
        {
            string logFileName = DateTime.Now.ToString("yyyyMMdd");

            using (StreamWriter streamWriter = new StreamWriter(logPath + "[" + logFileName + "]log.txt", true, Encoding.UTF8))
            {
                streamWriter.WriteLine("[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "] : " + message);
            }
        }

        #endregion

    }
}
