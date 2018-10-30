using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MusicPlayerLib
{
    public class CrashReportHandler
    {
        public static bool CreateCrashReport(Exception ex)
        {
            try
            {
                string crashReportFolder = Environment.CurrentDirectory + "\\Crash reports";
                if (!Directory.Exists(crashReportFolder))
                    Directory.CreateDirectory(crashReportFolder);
                DateTime now = DateTime.Now;
                string crashReportPath = crashReportFolder + "\\" + now.ToString().Replace(':', '-') + ".txt";
                string crashReportContent = ex.ToString();
                File.WriteAllText(crashReportPath, crashReportContent);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
