using Data.Common;
using SchoolProject.Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entites
{
    public class Subject
    {
        public class Subjects : GeneralLocalizer
        {
            public Subjects()
            {
                StudentSubject = new HashSet<StudentSubject>();
                DepartmetsSubjects = new HashSet<DepartmetSubject>();
                Ins_Subjects = new HashSet<Ins_Subject>();
            }
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int SubID { get; set; }
            [StringLength(500)]
            public string? SubjectNameAr { get; set; }
            public string? SubjectNameEn { get; set; }
            public int? Period { get; set; }
            public virtual ICollection<StudentSubject> StudentSubject { get; set; }
            public virtual ICollection<DepartmetSubject> DepartmetsSubjects { get; set; }
            public virtual ICollection<Ins_Subject> Ins_Subjects { get; set; }
        }
    }

}
