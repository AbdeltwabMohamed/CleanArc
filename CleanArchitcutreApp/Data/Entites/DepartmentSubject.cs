using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entites
{
    public class DepartmetSubject
    {

        public int DID { get; set; }
        public int SubID { get; set; }

        [ForeignKey("DID")]
        public virtual Department? Department { get; set; }

        [ForeignKey("SubID")]
        public virtual Subject? Subject { get; set; }
    }
}
