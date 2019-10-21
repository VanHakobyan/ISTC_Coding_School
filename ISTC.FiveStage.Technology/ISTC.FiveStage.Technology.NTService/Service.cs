using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISTC.FiveStage.Technology.NTService
{
    public partial class Service : ServiceBase
    {
        private ServiceLogic _sl;
        public static readonly CancellationTokenSource Source = new CancellationTokenSource();
        public readonly CancellationToken Token = Source.Token;


        public Service()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Task task = new Task(Start, Token, TaskCreationOptions.LongRunning);
            task.Start();
        }

        public void Start()
        {
            _sl = new ServiceLogic();
            _sl.Init();
        }
        protected override void OnStop()
        {
            Source.Cancel();
        }

    }
}
