using Data.Entites;
using Infrastracutre.Data;
using Infrastracutre.Interfaces;

namespace Infrastracutre.Repos
{
    public class DepartmentRepositry : BaseRepositry<Department>, IDepartmentRepositry
    {
        public DepartmentRepositry(ApplicationDbContext context) : base(context)
        {

        }


    }
}
