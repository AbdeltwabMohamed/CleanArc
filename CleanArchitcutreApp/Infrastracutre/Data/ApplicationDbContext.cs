using Data.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracutre.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments{ get; set; }
        public DbSet<Subject> subjects{ get; set; }
        public DbSet<DepartmetSubject> departmetSubjects{ get; set; }
        public DbSet<StudentSubject> studentSubjects{ get; set; }
        
    }
}
