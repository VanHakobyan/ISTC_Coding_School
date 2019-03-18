using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISTC.FiveStage.Technology.DependencyInjection.DI_02.Services
{
    public interface IMySingletonService
    {
        IMyTransientService MyTransientService { get; }
    }

    public interface IMyTransientService { }

    public class MySingletonService : IMySingletonService
    {
        public IMyTransientService MyTransientService { get; }

        public MySingletonService(IMyTransientService myTransientService)
        {
            MyTransientService = myTransientService;
        }
    }

    public class MyTransientService : IMyTransientService
    {
    }
}
