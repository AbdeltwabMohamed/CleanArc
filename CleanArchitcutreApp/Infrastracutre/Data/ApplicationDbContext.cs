using Data.Entites;
using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;

namespace Infrastracutre.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Subject> subjects { get; set; }
        public DbSet<DepartmetSubject> departmetSubjects { get; set; }
        public DbSet<StudentSubject> studentSubjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DepartmetSubject>().HasKey(e => new { e.SubID, e.DID });
            modelBuilder.Entity<Ins_Subject>().HasKey(e => new { e.SubId, e.InsId });
            modelBuilder.Entity<StudentSubject>().HasKey(e => new { e.SubID, e.StudID });
            modelBuilder.Entity<Department>().HasOne(e => e.Instructor).WithOne(e => e.departmentManager);
            modelBuilder.Entity<Instructor>().HasOne(e => e.department).WithMany(e => e.Instructors).HasForeignKey(e => e.DID);

            base.OnModelCreating(modelBuilder);

        }
    }
}
