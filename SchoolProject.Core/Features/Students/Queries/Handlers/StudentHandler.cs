using MediatR;
using SchoolProject.Core.Features.Students.Queries.Models;
using SchoolProject.Data.Entities;
using SchoolProject.Service.Abstracts;

namespace SchoolProject.Core.Features.Students.Queries.Handlers
{
    public class StudentHandler : IRequestHandler<GetStudentListQuery, List<Student>>
    {
        #region Fields
        private readonly IStudentService _studentService;

        #endregion


        #region Constructors
        public StudentHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }

        #endregion  


        #region Handle Functions

        public async Task<List<Student>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
           return await _studentService.GetStudentListAsync();
        }
        #endregion
    }
}
