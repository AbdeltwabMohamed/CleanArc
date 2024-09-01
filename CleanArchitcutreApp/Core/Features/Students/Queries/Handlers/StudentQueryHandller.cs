using AutoMapper;
using Core.Bases;
using Core.Features.Students.Queries.Models;
using Core.Features.Students.ViewModels;
using Core.Resources;
using Core.Wrappers;
using Data.Entites;
using MediatR;
using Microsoft.Extensions.Localization;
using Service.Interfaces;
using System.Linq.Expressions;

namespace Core.Features.Students.Queries.Handlers
{
    public class StudentQueryHandller :
        ResponseHandler, IRequestHandler<GetStudentList, Response<IEnumerable<StudentListVM>>>,
        IRequestHandler<GetStudentById, Response<SingleStudentVM>>,
        IRequestHandler<GetStudentListPaginated, PaginatedResult<StudentListVM>>
    {
        private readonly IStudentServices _studentServices;
        private readonly IMapper mapper;
        private readonly IStringLocalizer<SharedResource> stringLocalizer;

        public StudentQueryHandller(IStudentServices st, IMapper mapper, IStringLocalizer<SharedResource> stringLocalizer)
        {
            _studentServices = st;
            this.mapper = mapper;
            this.stringLocalizer = stringLocalizer;
        }
        public async Task<Response<IEnumerable<StudentListVM>>> Handle(GetStudentList request, CancellationToken cancellationToken)
        {
            var Result = Task.FromResult(_studentServices.GetAll().ToList()).Result;
            var res2 = mapper.Map<IEnumerable<StudentListVM>>(Result);
            return Success(res2);



        }

        public async Task<Response<SingleStudentVM>> Handle(GetStudentById request, CancellationToken cancellationToken)
        {
            var res = Task.FromResult(_studentServices.GetById(request.Id)).Result;
            var result = mapper.Map<SingleStudentVM>(res);
            return Success(result);
        }

        public async Task<PaginatedResult<StudentListVM>> Handle(GetStudentListPaginated request, CancellationToken cancellationToken)
        {
            Expression<Func<Student, StudentListVM>> expression = e => new StudentListVM
            (e.StudID, e.getActiveNameByLanguage(e.NameAr, e.NameEn), e.Address, e.Phone, e.Department.getActiveNameByLanguage(e.NameAr, e.NameEn));
            var filterd = _studentServices.Filter(request.OrderBy, request.Search);
            var result = await filterd.Select(expression).ToPaginatedListAsync(request.PageNumber, request.PageSize);
            return result;

        }
    }
}
