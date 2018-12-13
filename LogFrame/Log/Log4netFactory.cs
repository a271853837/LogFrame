using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogFrame.Log
{
    public class Log4netFactory : ILoggerFactory
    {
        internal static Dictionary<string, ILogger> map = new Dictionary<string, ILogger>(128);

        public Log4netFactory(string configName)
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        public ILogger GetLogger(string name)
        {
            lock (this)
            {
                ILogger logger = null;
                if (!map.TryGetValue(name, out logger))
                {
                    logger = new Logger4netAdapter(log4net.LogManager.GetLogger(name));
                    map[name] = logger;
                }
                return logger;
            }
        }

        public ILogger GetLogger(Type type)
        {
            return GetLogger(type.FullName);
        }
    }
}
