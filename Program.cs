using static System.Console; 
using Microsoft.EntityFrameworkCore; 
using System.Linq;
using SchoolDB.Models;
using SchoolDB.Data;
using System; 
using Microsoft.EntityFrameworkCore.Infrastructure; 
using Microsoft.Extensions.DependencyInjection; 
using Microsoft.Extensions.Logging; 
using Microsoft.Extensions.Logging.Console;
namespace SchoolDB
{  
    class Program    
{
        static void QueryingStudents()
        {
        using (var db = new SchoolContext())
            {                  
            var loggerFactory = db.GetService<ILoggerFactory>(); 
            loggerFactory.AddProvider(new ConsoleLoggerProvider());
                  WriteLine("Студенты и предметы:");
                  IQueryable<Enrollment> ens = db.Enrollments
                  .Include(stdnt => stdnt.Student)
                  .Include(crs => crs.Course);
                  foreach (Enrollment e in ens)
                    {
                    WriteLine($"  {e.Student.LastName} изучает {e.Course.Title}.");
                    } 
            }
        }
        static void Main(string[] args)
            {
            var context = new SchoolContext();
            DbInitializer.Initialize(context);
            QueryingStudents();
            }
    }
}
