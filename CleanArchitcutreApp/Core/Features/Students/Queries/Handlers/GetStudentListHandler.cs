using AutoMapper;
using Core.Features.Students.Queries.Models;
using Core.Features.Students.ViewModels.Students;
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
    public class GetStudentListHandler : IRequestHandler<GetStudentList, IEnumerable<StudentListVM>>
    {
        private readonly IStudentServices _studentServices;
        private readonly IMapper mapper;

        public GetStudentListHandler(IStudentServices st, IMapper mapper)
        {
            _studentServices = st;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<StudentListVM>> Handle(GetStudentList request, CancellationToken cancellationToken)
        {
           var Result= Task.FromResult(_studentServices.GetAll()).Result;
            var res2=mapper.Map<List<StudentListVM>>(Result);
            return res2;

            
            
        }
    }
}
