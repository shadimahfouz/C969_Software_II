using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace C969PA
{
    class ActivityLog
    {
        public static void TrackUserLogin(int userId)
        {
            //This will create a log file in bin\debug\netcoreapp3.1\log.txt if it does not exist, then populate it with login dates, times, and name of user who logged in. 

            string path = @"log.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("C969 Log File");
                }
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                string logText = $"User {userId} logged in at {AppDatabase.LogTimeStamp()}" + Environment.NewLine;
                sw.WriteLine(logText);
            }


        }
    }
}
