
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class SqlLoggerDAO 
    {
        public List<string> list = new List<string>();
        public string[] GetAll()
        {
            return list.ToArray();
        }

        public void Write(string mensaje)
        {
            list.Add(mensaje);
        }
    }
}
