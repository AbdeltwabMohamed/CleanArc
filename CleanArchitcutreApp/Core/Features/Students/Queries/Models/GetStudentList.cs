using Core.Features.Students.ViewModels.Students;
using Data.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Features.Students.Queries.Models
{
    public class GetStudentList:IRequest<IEnumerable<StudentListVM>>
    {
    }
}
