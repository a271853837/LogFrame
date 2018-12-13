using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogFrame.Log
{
    public class Logger4netAdapter : ILogger
    {
        private log4net.ILog logger;

        public Logger4netAdapter(log4net.ILog logger)
        {
            this.logger = logger;
        }

        public void Info(object message)
        {
            logger.Info(message);
        }

        public void Info(string message, params object[] args)
        {
            logger.Info(this.tryFormart(message, args));
        }


        private string tryFormart(string s, params object[] args)
        {
            try
            {
                if (args == null || args.Length == 0)
                    return s;
                return string.Format(s, args);
            }
            catch
            {
                return String.Empty;
            }
        }
    }
}
