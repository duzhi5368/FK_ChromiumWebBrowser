using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpBrowser
{
    class Log
    {
        public static void WriteLog(string strLog)
        {
            string sFilePath = DateTime.Now.ToString("yyyyMM");
            string sFileName = "Log_" + DateTime.Now.ToString("dd") + ".log";
            sFileName = sFilePath + "\\" + sFileName;
            if (!Directory.Exists(sFilePath))
            {
                Directory.CreateDirectory(sFilePath);
            }
            FileStream fs;
            StreamWriter sw;
            if (File.Exists(sFileName))
            {
                fs = new FileStream(sFileName, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(sFileName, FileMode.Create, FileAccess.Write);
            }
            sw = new StreamWriter(fs);
            sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + "   ---   " + strLog);
            sw.Close();
            fs.Close();
        }
    }
}
