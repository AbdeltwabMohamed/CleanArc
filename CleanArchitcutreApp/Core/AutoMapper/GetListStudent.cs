﻿using Core.Features.Students.ViewModels.Students;
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
        public void MapStudentListVM()
        {
            CreateMap<Student,StudentListVM>().ForMember(dest=>dest.DepartmentName1,srs=>srs.MapFrom(s=>s.Department.DName));
        }
    }
}
