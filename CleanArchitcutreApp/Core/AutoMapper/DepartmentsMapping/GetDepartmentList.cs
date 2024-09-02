using Core.Features.Departments.Query.Models;
using Data.Entites;

namespace Core.Profiles
{
    public partial class DepartmentProfile
    {
        public void MapDepartmentList()
        {
            CreateMap<Department, GetDepartmentsList>().ForMember(des => des.DName, src => src.MapFrom(s => s.getActiveNameByLanguage(s.DNameAr, s.DNameEn)));
        }
    }
}
