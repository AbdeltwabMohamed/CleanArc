using Data.Common;
using SchoolProject.Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entites
{
    public class Subject : GeneralLocalizer
    {


        public Subject()
        {
            StudentSubject = new HashSet<StudentSubject>();
            DepartmetsSubjects = new HashSet<DepartmetSubject>();
            Ins_Subjects = new HashSet<Ins_Subject>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int SubID { get; set; }
        [StringLength(500)]
        public string? SubjectNameAr { get; set; }
        public string? SubjectNameEn { get; set; }
        public DateTime? Period { get; set; }
        public virtual ICollection<StudentSubject> StudentSubject { get; set; }
        public virtual ICollection<DepartmetSubject> DepartmetsSubjects { get; set; }
        public virtual ICollection<Ins_Subject> Ins_Subjects { get; set; }

    }

}
