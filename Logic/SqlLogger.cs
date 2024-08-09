using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class SqlLogger
    {
        SqlLoggerDAO dAO = new SqlLoggerDAO();

        public void Write(string mensaje)
        {
            dAO.Write(mensaje);
        }

        public string[] GetAll()
        {
            return dAO.GetAll();
        }
    }
}
