
using Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class FileLoggerDAO 
    {
        public string[] ReadAll()
        {
            var logs = new List<string>();

            using(StreamReader reader = new StreamReader(ConfigurationManager.AppSettings["Pathcon"], true))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    logs.Add(line);
                }

                return logs.ToArray();
            }
        }

        public void Write(string mensaje)
        {
            using (StreamWriter writer = new StreamWriter(ConfigurationManager.AppSettings["Pathcon"], true))
            {
                writer.WriteLine(mensaje);
            }
        }
    }
}
