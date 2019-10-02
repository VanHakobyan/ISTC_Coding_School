using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.FourthStage.Database.EF.DatabaseFirst2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MonitoringEntities db = new MonitoringEntities())
            {
                var profileAllInfoById = db.fn_GetLinkedinProfileAllInfoById(9).Where(x => x.ConnectionCount.HasValue).ToList();
                //select * from linkedinProfile lp
                //join linkedinLanguages ll on ll.LinkedinProfileId=lp.id
                //db.SaveChanges();
            }
        }
    }
}
