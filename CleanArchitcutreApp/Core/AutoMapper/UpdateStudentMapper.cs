using Core.Features.Students.Commands.Models;
using Data.Entites;

namespace Core.Profiles
{
    public partial class StudentProfile
    {
        public void MapEditStudentCommandsToStudent()
        {
            CreateMap<EditStudentCommand, Student>();
        }
    }
}
