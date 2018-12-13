using LogFrame.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            //log4net.Config.XmlConfigurator.Configure();

            //ILog log = LogManager.GetLogger("testApp.Logging");//获取一个日志记录器

            //log.Info(DateTime.Now.ToString() + ": login success");//写入一条新log

            ILogger logger1 = Log.LoggerManager.GetLogger("testApp.Logging");
            ILogger logger2 = Log.LoggerManager.GetLogger("testApp.Logging");

            var logger3 = LoggerManager.GetLogger(typeof(Program));

            logger3.Info("122223");
            Console.WriteLine(logger1 == logger2);
            //logger.Info("123");
            Console.ReadLine();
        }
    }
}
