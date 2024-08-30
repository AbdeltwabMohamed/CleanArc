using AutoMapper;

namespace Core.Profiles
{
    public partial class StudentProfile : Profile
    {
        public StudentProfile()
        {
            MapStudentListVM();

            MapSingleStudent();
            MapAddStudentCommandsToStudent();
            MapEditStudentCommandsToStudent();
        }
    }
}
