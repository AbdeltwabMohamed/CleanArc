using Azure.Core;
using Core.Bases;
using Core.Features.Students.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Features.Students.Queries.Models
{
    public class GetStudentById :IRequest<Response<SingleStudentVM>>
    {
        public int Id { get; set; }
    }
}
