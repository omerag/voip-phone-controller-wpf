using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voip_phone_controller_wpf.model
{

    class Log
    {

        public static void AddCall(string ip, string lineExtension, string number, string status)
        {
            string path = "logs/exit calls.txt";


            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                Directory.CreateDirectory("logs");
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("New call log file:");
                }
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("ip " + ip +", line: " + lineExtension + " called " + number + " " + status );
            }
        }
    }


}
