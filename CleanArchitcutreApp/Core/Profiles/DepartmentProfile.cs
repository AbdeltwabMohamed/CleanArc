using AutoMapper;

namespace Core.Profiles
{
    public partial class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            MapDepartmentList();
        }
    }
}
