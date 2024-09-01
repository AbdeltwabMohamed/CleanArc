using AutoMapper;
using Core.Bases;
using Core.Features.Students.Commands.Models;
using Core.Resources;
using Data.Entites;
using MediatR;
using Microsoft.Extensions.Localization;
using Service.Interfaces;

namespace Core.Features.Students.Commands.Handlers
{
    internal class StudentCommandHandller : ResponseHandler, IRequestHandler<AddStudentCommand, Response<string>>,
        IRequestHandler<EditStudentCommand, Response<string>>,
        IRequestHandler<DeleteStudentCommand, Response<string>>
    {
        private readonly IStudentServices _studentServices;
        private readonly IMapper mapper;
        private readonly IStringLocalizer<SharedResource> stringLocalizer;

        public StudentCommandHandller(IStudentServices studentServices, IMapper mapper, IStringLocalizer<SharedResource> stringLocalizer)
        {
            _studentServices = studentServices;
            this.mapper = mapper;
            this.stringLocalizer = stringLocalizer;
        }

        public async Task<Response<string>> Handle(EditStudentCommand request, CancellationToken cancellationToken)
        {

            _studentServices.Update(mapper.Map<Student>(request));

            return Success<string>("Updated Successfully", null, "dONE");
        }

        public async Task<Response<string>> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            var isExist = await _studentServices.GetById(request.Id);
            if (isExist == null)
                return NotFound<string>();

            _studentServices.Delete(isExist);
            return Deleted<string>();
        }

        async Task<Response<string>> IRequestHandler<AddStudentCommand, Response<string>>.Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            var isExist = _studentServices.GetAll().AsQueryable().Where(e => e.getActiveNameByLanguage(e.NameAr, e.NameEn) == request.Name);
            if (isExist.Any()) { return BadRequest<string>(stringLocalizer[SharedResouceKeys.NameAlreadyFound]); }

            var res = mapper.Map<Student>(request);
            _studentServices.Add(res);

            return Success<string>("Added Successfully");

        }
    }
}
