using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class LoggerAdapter : ILogger
    {
        Logger logger;

        
        public LoggerAdapter(LoggerType type, string pathcc)
        {
            logger = new Logger(type, pathcc);
        }


        public List<Log> GetAll()
        {
            string[] lista = (logger.ReadAll());
            var logs = new List<Log>();

            foreach (var log in lista)
            {
                logs.Add(new Log { message = log, severity = Log.Severity.weak });

            }

            return logs;
        }

        public void Store(Log log)
        {
            var mensaje = log.message;
            logger.Write(mensaje);
        }
    }
}
