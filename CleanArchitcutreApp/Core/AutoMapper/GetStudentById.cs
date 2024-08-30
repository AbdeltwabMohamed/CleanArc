using Core.Features.Students.ViewModels;
using Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Profiles
{
    public partial class StudentProfile
    {
        public void MapSingleStudent()
        {
            CreateMap<Student, SingleStudentVM>().ForMember(dest => dest.DepartmentName1, srs => srs.MapFrom(s => s.Department.DName));
        }
    }
}
