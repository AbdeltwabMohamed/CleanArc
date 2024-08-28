using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Profiles
{
    public partial class StudentProfile:Profile
    {
        public StudentProfile()
        {
            MapStudentListVM();
        }
    }
}
