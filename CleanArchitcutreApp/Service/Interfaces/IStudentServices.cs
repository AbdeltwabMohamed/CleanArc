using Data.Entites;

namespace Service.Interfaces
{
    public interface IStudentServices
    {
        IEnumerable<Student> GetAll();
        Student GetById(int id);

        Student Add(Student student);

        Student Update(Student student);

        bool isNameExist(string n);
    }
}
