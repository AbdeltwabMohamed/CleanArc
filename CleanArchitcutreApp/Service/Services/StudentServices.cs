using Data.Entites;
using Data.Helpers;
using Infrastracutre.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        public Student Delete(Student t)
        {
            return repositry.Delete(t);
        }

        public IQueryable<Student> Filter(StudentOrderFilters? Order, string Search)
        {
            var Students = GetAll();
            if (Search != null || Search != String.Empty)
            {
                Students = Students.Where(e => e.Name.Contains(Search) || e.StudID.ToString().Contains(Search) || e.Department.DName.Contains(Search));

            }
            switch (Order)
            {
                case StudentOrderFilters.StudentId:
                    Students.OrderBy(e => e.StudID);
                    break;
                case StudentOrderFilters.StudentName:
                    Students.OrderBy(e => e.Name);
                    break;
                case StudentOrderFilters.StudentDepartmentName:
                    Students.OrderBy(e => e.Department.DName);
                    break;
                default:
                    Students.OrderBy(e => e.StudID); break;

            }
            return Students;
        }

        public IQueryable<Student> GetAll()
        {
            return repositry.GetAll().AsNoTracking().AsQueryable();
        }

        public async Task<Student> GetById(int id)
        {
            return await repositry.GetById(id);
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
