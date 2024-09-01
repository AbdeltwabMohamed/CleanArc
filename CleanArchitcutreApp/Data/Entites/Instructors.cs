using Data.Common;
using Data.Entites;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Data.Entities
{
    public class Instructor : GeneralLocalizer
    {
        public Instructor()
        {
            Instructors = new HashSet<Instructor>();
            Ins_Subjects = new HashSet<Ins_Subject>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InsId { get; set; }
        public string? ENameAr { get; set; }
        public string? ENameEn { get; set; }
        public string? Address { get; set; }
        public string? Position { get; set; }
        public int? SupervisorId { get; set; }
        public decimal? Salary { get; set; }
        public string? Image { get; set; }
        public int DID { get; set; }
        [ForeignKey(nameof(DID))]
        public virtual Department? department { get; set; }

        public virtual Department? departmentManager { get; set; }


        [ForeignKey(nameof(SupervisorId))]
        public virtual Instructor? Supervisor { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }

        public virtual ICollection<Ins_Subject> Ins_Subjects { get; set; }
    }

}