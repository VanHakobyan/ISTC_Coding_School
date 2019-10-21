using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;

namespace ISTC.FiveStage.Technology.NTService
{
    public class ServiceLogic
    {
        private readonly Timer _timer = new Timer(TimeSpan.FromSeconds(30).TotalMilliseconds);
       
        public void Init()
        {
            _timer.Elapsed += TimerOnElapsed;
            _timer.Start();
        }

        private void TimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                WriteLog();
            }
            catch (Exception ex)
            {
            }
        }

        public void WriteLog()
        {
            var filePath = @"D:\logFile.log";
            if (File.Exists(filePath))
            {
                File.AppendAllText(filePath, $"{DateTime.Now.ToShortTimeString()}{Environment.NewLine}");
            }
            else
            {
                try
                {
                    var fileStream = File.Create(filePath);
                    fileStream.Dispose();
                    fileStream.Close();
                    File.AppendAllText(filePath, $"{DateTime.Now.ToShortTimeString()}");

                }
                catch (Exception e)
                {
                }
            }
        }
    }
}
