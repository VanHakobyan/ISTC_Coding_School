using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.FourthStage.Database.Bindings.Bindings_01
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ModelContainer dbContainer = new ModelContainer())
            {
                //Subject subject = new Subject { Name = "Analiz", Credit = 8, Type = "Vat" };
                var subject = dbContainer.Subjects.FirstOrDefault(x => x.Name == "Analiz");

                Student student = new Student { FirstName = "Vanik", LastName = "Hakobyan", Age = 22, GPA = 12, Status = "chka" };

                subject.Students.Add(student);
                student.Subjects.Add(subject);
                //Faculty faculty = new Faculty { Name = "IKM" };
                var faculty = dbContainer.Faculties.FirstOrDefault(x => x.Name == "IKM");
                
                faculty.Students.Add(student);

                //var dean = new Dean { LastName = "Dumanyan", FirstName = "Karen", About = "No any info", Age = 51, IsCorrupted = false, Faculty = faculty };

                //dbContainer.Deans.Add(dean);
                dbContainer.Students.Add(student);

                dbContainer.SaveChanges();
            }
        }
    }
}
