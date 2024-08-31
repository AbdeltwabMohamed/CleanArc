using Data.Entites;
using Data.Helpers;

namespace Service.Interfaces
{
    public interface IStudentServices
    {
        IQueryable<Student> GetAll();
        Task<Student> GetById(int id);

        Student Add(Student student);

        Student Update(Student student);

        bool isNameExist(string n);

        Student Delete(Student t);
        public IQueryable<Student> Filter(StudentOrderFilters? Order, string Search);

    }
}
