using System;
using System.IO;
using System.ServiceProcess;

namespace ISTC.FiveStage.Technology.WPFandService.Service
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            using (FileStream fileStream = new FileStream("E:\\Text1.txt", FileMode.OpenOrCreate))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.Write("Hello service!!!");
                }
            }

        }

        protected override void OnStop()
        {
            if (File.Exists("E:\\Text1.txt")) File.Delete("E:\\Text1.txt");
        }


        public void TestAndStart()
        {
            OnStart(null);
            Console.ReadKey();
            OnStop();
        }
    }
}
