using Core.Features.Students.Commands.Models;
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
        public void MapAddStudentCommandsToStudent()
        {
            CreateMap<AddStudentCommand, Student>();
        }
    }
}
