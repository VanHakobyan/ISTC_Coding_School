using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace ISTC.FiveStage.Technology.Logging.Nlog
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            Logger logger2 = LogManager.GetLogger("ISTCLogs");

            for (int i = 0; i < 10; i++)
            {
                logger.Info($"iteration {i}");
                logger2.Info($"iteration {i}");
            }


        }
    }
}
