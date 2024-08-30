using Data.Entites;
using Infrastracutre.Interfaces;
using Service.Interfaces;

namespace Service.Services
{
    public class StudentServices : IStudentServices
    {
        private readonly IBaseRepositry<Student> repositry;

        public StudentServices(IBaseRepositry<Student> repositry)
        {
            this.repositry = repositry;
        }

        public Student Add(Student student)
        {
            return repositry.Add(student);
        }

        public IEnumerable<Student> GetAll()
        {
            return repositry.GetAll();
        }

        public Student GetById(int id)
        {
            return repositry.GetById(id);
        }

        public bool isNameExist(string name)
        {
            return repositry.GetAll().Where(e => e.Name == name).FirstOrDefault() == null;
        }

        public Student Update(Student student)
        {
            return repositry.Update(student);

        }
    }
}
