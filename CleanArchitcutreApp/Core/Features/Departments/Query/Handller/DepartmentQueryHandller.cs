using AutoMapper;
using Core.Bases;
using Core.Features.Departments.Query.Models;
using MediatR;
using Service.Interfaces;

namespace Core.Features.Departments.Query.Handller
{
    public class DepartmentQueryHandller : ResponseHandler, IRequestHandler<GetDepartmentsList, Response<IEnumerable<GetDepartmentsList>>>
    {
        private readonly IDepartmentServices departmentServices;
        private readonly IMapper mapper;

        public DepartmentQueryHandller(IDepartmentServices departmentServices, IMapper mapper)
        {
            this.departmentServices = departmentServices;
            this.mapper = mapper;
        }
        public async Task<Response<IEnumerable<GetDepartmentsList>>> Handle(GetDepartmentsList request, CancellationToken cancellationToken)
        {
            var res = departmentServices.GetDepartments();
            var res2 = mapper.Map<IEnumerable<GetDepartmentsList>>(res);

            return Success(res2);
        }
    }
}
