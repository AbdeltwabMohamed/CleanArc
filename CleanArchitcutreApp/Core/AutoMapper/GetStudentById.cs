using Core.Features.Students.ViewModels;
using Data.Entites;

namespace Core.Profiles
{
    public partial class StudentProfile
    {
        public void MapSingleStudent()
        {
            CreateMap<Student, SingleStudentVM>().
                ForMember(dest => dest.DepartmentName1, srs => srs.MapFrom(s => s.Department.getActiveNameByLanguage(s.NameAr, s.NameEn)));
        }
    }
}
