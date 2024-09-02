using Data.Entites;

namespace Service.Interfaces
{
    public interface IDepartmentServices
    {
        IEnumerable<Department> GetDepartments();
    }
}
