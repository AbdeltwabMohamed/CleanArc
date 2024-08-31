using Core.Features.Students.ViewModels;
using Core.Wrappers;
using Data.Helpers;
using MediatR;

namespace Core.Features.Students.Queries.Models
{
    public class GetStudentListPaginated : IRequest<PaginatedResult<StudentListVM>>
    {
        public int PageSize { get; set; }

        public int PageNumber { get; set; }

        public StudentOrderFilters? OrderBy { get; set; }
        public string? Search { get; set; }
    }

}
