using Data.Entites;
using Infrastracutre.Interfaces;
using Service.Interfaces;

namespace Service.Services
{
    public class DepartmentServices : IDepartmentServices
    {
        private readonly IDepartmentRepositry departmentRepositry;

        public DepartmentServices(IDepartmentRepositry departmentRepositry)
        {
            this.departmentRepositry = departmentRepositry;
        }
        public IEnumerable<Department> GetDepartments()
        {
            return departmentRepositry.GetAll();
        }
    }
}
