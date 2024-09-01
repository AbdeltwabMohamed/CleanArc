using Core.Bases;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Core.Features.Students.Commands.Models
{
    public class AddStudentCommand : IRequest<Response<string>>
    {
        [Required]
        [MaxLength(5)]

        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public int? DID { get; set; }
    }



}
