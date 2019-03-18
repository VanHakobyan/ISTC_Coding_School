using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISTC.FiveStage.Technology.DependencyInjection.DI_01.Services
{
    public class FirstService : IFirstService
    {
        public string Welcome { get; set; }
        public FirstService()
        {
            Welcome = "Welcome ISTC .Net Core students!!!"; 
        }
        public string WelcomeISTC()
        {
            return Welcome;
        }
    }
}
