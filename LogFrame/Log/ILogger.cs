using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogFrame.Log
{
    public interface ILogger
    {
        void Info(object message);

        void Info(string message, params object[] args);
    }
}
