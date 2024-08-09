using Datos;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class FileLogger
    {
        FileLoggerDAO dAO = new FileLoggerDAO();
        public void Write(string mensaje)
        {
            dAO.Write(mensaje);   
        }

        public string[] GetAll()
        {
            return dAO.ReadAll();
        }
    }
}
