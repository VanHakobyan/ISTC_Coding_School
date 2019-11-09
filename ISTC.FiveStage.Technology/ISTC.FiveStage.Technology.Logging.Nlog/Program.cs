using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NLog;

namespace ISTC.FiveStage.Technology.Logging.Nlog
{
    class Program
    {
        static Logger logger = LogManager.GetLogger("ISTCLogs");
        static int Method(int first, int second)
        {
            try
            {
                return first / second;
            }
            catch (Exception e)
            {
                logger.Error(e, MethodBase.GetCurrentMethod().Name);
                return -1;
            }
        }
        static void Main(string[] args)
        {
            //Logger logger = LogManager.GetCurrentClassLogger();

            for (int i = 0; i < 10000; i++)
            {
                var method = Method(i + 1, i);
                //logger.Info($"iteration {i} {Environment.OSVersion.VersionString} {Environment.SystemDirectory}");
                Thread.Sleep(5);
            }


        }
    }
}
