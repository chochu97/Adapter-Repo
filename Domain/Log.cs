using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Log
    {
        public string message { get; set; }
        public Severity severity { get; set; }
        public enum Severity
        {
            weak,
            strong
        }
    }
}
