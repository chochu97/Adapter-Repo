using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Logger
    {
        public string pathcon;
        public string typecon;

        FileLogger file = new FileLogger();
        SqlLogger sql = new SqlLogger();    
        public Logger(LoggerType type, string pathconnec)
        {
            pathcon = pathconnec;
            typecon = type.ToString(); 
        }

        public void Write(string message)
        {
            
            if (typecon == "File")
            { 
                file.Write(message);
            }
            else
            {
                sql.Write(message);
            }
        }

        public string[] ReadAll()
        {
            if(typecon == "File")
            {
                return file.GetAll();
            }
            else
            {
                return sql.GetAll();
            }
        }

    }
    public enum LoggerType
    {
        Sql,
        File
    }
}
