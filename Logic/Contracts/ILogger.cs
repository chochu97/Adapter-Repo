using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface ILogger
    {
        void Store(Log log);

        List<Log> GetAll();
    }
}
