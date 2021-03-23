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
            //string filePath = "log.text";
            //string logText = $"User {userId} logged in at {AppDatabase.LogTimeStamp()}" + Environment.NewLine;
            //File.AppendAllText(filePath, logText);

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
