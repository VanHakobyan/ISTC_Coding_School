using System;

namespace ISTC.FourthStage.Database.EF.DatabaseFirst2
{
    public class ProxyViewModel
    {
        public Guid Guid { get; set; }
        public string Country { get; set; }
        public string Ip { get; set; }
        public string Port { get; set; }
        public string Type { get; set; }
        public int? Test { get; set; }
    }
}
