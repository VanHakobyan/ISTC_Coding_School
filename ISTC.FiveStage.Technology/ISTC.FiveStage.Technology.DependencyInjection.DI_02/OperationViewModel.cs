using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISTC.FiveStage.Technology.DependencyInjection.DI_02
{
    public class OperationViewModel
    {
        public string Transient { get; set; }
        public string Scoped { get; set; }
        public string Singleton { get; set; }
        //public string SingletonInstance { get; set; }
        public string Service { get; set; }

    }
}
