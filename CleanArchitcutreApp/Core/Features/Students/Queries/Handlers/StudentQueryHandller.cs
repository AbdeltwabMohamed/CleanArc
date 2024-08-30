using AutoMapper;
using Core.Bases;
using Core.Features.Students.Queries.Models;
using Core.Features.Students.ViewModels;
using Data.Entites;
using MediatR;
using Service.Interfaces;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Features.Students.Queries.Handlers
{
    public class StudentQueryHandller :
        ResponseHandler,IRequestHandler<GetStudentList, Response<IEnumerable<StudentListVM>>>,
        IRequestHandler<GetStudentById, Response<SingleStudentVM>>
    {
        private readonly IStudentServices _studentServices;
        private readonly IMapper mapper;

        public StudentQueryHandller(IStudentServices st, IMapper mapper)
        {
            _studentServices = st;
            this.mapper = mapper;
        }
        public async Task<Response<IEnumerable<StudentListVM>>> Handle(GetStudentList request, CancellationToken cancellationToken)
        {
           var Result= Task.FromResult(_studentServices.GetAll()).Result;
            var res2=mapper.Map<IEnumerable<StudentListVM>>(Result);
            return Success(res2);

            
            
        }

        public async Task<Response<SingleStudentVM>> Handle(GetStudentById request, CancellationToken cancellationToken)
        {
             var res=Task.FromResult(_studentServices.GetById(request.Id)).Result;
            var result=mapper.Map<SingleStudentVM>(res);
            return Success(result);
        }
    }
}
