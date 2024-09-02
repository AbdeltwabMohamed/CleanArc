using Data.Entites;
using Infrastracutre.Repos;
using Service.Interfaces;

namespace Service.Services
{
    public class DepartmentServices : IDepartmentServices
    {
        private readonly DepartmentRepositry departmentRepositry;

        public DepartmentServices(DepartmentRepositry departmentRepositry)
        {
            this.departmentRepositry = departmentRepositry;
        }
        public IEnumerable<Department> GetDepartments()
        {
            return departmentRepositry.GetAll();
        }
    }
}
