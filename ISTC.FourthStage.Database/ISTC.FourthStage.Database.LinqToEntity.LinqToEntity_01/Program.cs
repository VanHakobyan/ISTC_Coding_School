using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.FourthStage.Database.LinqToEntity.LinqToEntity_01
{
    class Program
    {
        static void Main(string[] args)
        {
            GithubProfile a;
            using (MonitoringEntities db = new MonitoringEntities())
            {
                db.Configuration.AutoDetectChangesEnabled = false;
                var Lqueryable = db.GithubProfiles.Select(x => x).Where(x => x.Company.ToLower() == "betconstruct")
                    .OrderByDescending(x => x.Name).ToList();
                a = Lqueryable.First();
                Console.WriteLine(db.ChangeTracker.HasChanges());//false
                a.Name = "";
                Console.WriteLine(db.ChangeTracker.HasChanges());//true
                //db.Entry(a).State = EntityState.Modified;
                Console.WriteLine(db.ChangeTracker.HasChanges());//true 
                //db.SaveChanges();
            }

            using (MonitoringEntities db = new MonitoringEntities())
            {
                db.Entry(a).State = EntityState.Modified;
                Console.WriteLine(db.ChangeTracker.HasChanges());//true
                db.SaveChanges();
            }
        }
    }
}