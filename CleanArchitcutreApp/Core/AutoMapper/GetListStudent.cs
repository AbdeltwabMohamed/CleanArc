using Core.Features.Students.ViewModels;
using Data.Entites;

namespace Core.Profiles
{
    public partial class StudentProfile
    {
        public void MapStudentListVM()
        {
            CreateMap<Student, StudentListVM>().ForMember(dest => dest.DepartmentName1, srs => srs.MapFrom(s => s.Department.getActiveNameByLanguage(s.NameAr, s.NameEn)))
                .ForMember(des => des.Name, src => src.MapFrom(s => s.getActiveNameByLanguage(s.NameAr, s.NameEn)));
        }
    }
}
