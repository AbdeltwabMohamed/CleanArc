using Data.Entites;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Data.Entities
{
    public class Ins_Subject
    {
        public int InsId { get; set; }
        public int SubId { get; set; }
        [ForeignKey(nameof(InsId))]
        public virtual Instructor? instructor { get; set; }
        [ForeignKey(nameof(SubId))]
        public virtual Subject? Subject { get; set; }

    }
}