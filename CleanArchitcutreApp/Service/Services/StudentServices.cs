using Data.Entites;
using Infrastracutre.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class StudentServices : IStudentServices
    {
        private readonly IBaseRepositry<Student> repositry;

        public StudentServices(IBaseRepositry<Student> repositry)
        {
            this.repositry = repositry;
        }
        public IEnumerable<Student> GetAll()
        {
           return repositry.GetAll();
        }
    }
}
