using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogFrame.Log
{
    public class LoggerManager
    {
        private static object _obj = new object();
        private static ILoggerFactory _loggerFactory;
        private LoggerManager()
        {

        }

        private static ILoggerFactory Factory
        {
            get {
                if (_loggerFactory == null)
                {
                    lock (_obj)
                    {
                        if (_loggerFactory == null)
                        {
                            _loggerFactory = new Log4netFactory(string.Empty);
                        }
                    }
                }
                return _loggerFactory;
            }
        }

        public static ILogger GetLogger(string name)
        {
            return Factory.GetLogger(name);
        }


        public static ILogger GetLogger(Type type)
        {
            return Factory.GetLogger(type);
        }
    }
}
