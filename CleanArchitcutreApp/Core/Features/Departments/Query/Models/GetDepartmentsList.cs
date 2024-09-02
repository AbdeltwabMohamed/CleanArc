using Core.Bases;
using MediatR;

namespace Core.Features.Departments.Query.Models
{
    public class GetDepartmentsList : IRequest<Response<IEnumerable<GetDepartmentsList>>>
    {
        public string DName { get; set; }

        public int InsManager { get; set; }
    }
}
