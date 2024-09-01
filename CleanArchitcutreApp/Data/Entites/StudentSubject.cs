using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entites
{
    public class StudentSubject
    {
        public int StudID { get; set; }
        public int SubID { get; set; }
        public decimal? grade { get; set; }

        [ForeignKey("StudID")]
        public virtual Student? Student { get; set; }

        [ForeignKey("SubID")]
        public virtual Subject? Subject { get; set; }

    }
}
