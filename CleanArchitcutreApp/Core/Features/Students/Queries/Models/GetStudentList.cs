using Core.Bases;
using Core.Features.Students.ViewModels;
using Data.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Features.Students.Queries.Models
{
    public class GetStudentList:IRequest<Response<IEnumerable<StudentListVM>>>
    {
    }
}
