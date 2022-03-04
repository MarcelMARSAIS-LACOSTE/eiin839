using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Diagnostics;
using System.IO;

namespace BasicWebServer
{
    internal class MyMethods
    {
        public string MyMethod(string param1, string param2)
        {
            // return "<html><body> Hello " + param1 + " et " + param2 + "</body></html>";
            /*Process p = new Process();
            p.StartInfo.FileName = "C:\\Users\\marcelmarsais\\AppData\\Local\\Programs\\Python\\Python310\\python.exe";
            p.StartInfo.Arguments = "";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.Start();

            p.WaitForExit();
            string output = p.StandardOutput.ReadToEnd();

            return output;*/

            // http://localhost:8080/MyMethod?param1=Marcel&param2=Marsais-Lacoste <- URL

            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\\Users\\marcelmarsais\\AppData\\Local\\Programs\\Python\\Python310\\python.exe"; // Specify exe name.
            start.Arguments = "..\\..\\..\\BasicWebServer\\MyMethod.py " + param1 + " " + param2; // Specify arguments.
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            //
            // Start the process.
            //
            using (Process process = Process.Start(start))
            {
                //
                // Read in all the text from the process with the StreamReader.
                //
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.WriteLine(result);
                    //Console.ReadLine();
                    // Console.WriteLine("la");
                    //Console.ReadLine();
                    return result;
                }
            }
        }

        public string incr(string val)
        {
            // http://localhost:8080/incr?val=...

            int valInt = Int32.Parse(val);
            valInt += 1;

            return "incr OK " + valInt;
        }
    }
}
