namespace ISTC.FiveStage.Technology.WPFandService.Service
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
#if DEBUG
            Service1 service = new Service1();
            service.TestAndStart();
            //Process.Start("");

#else
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new Service1(), 
            };
            ServiceBase.Run(ServicesToRun);
#endif
        }
    }
}