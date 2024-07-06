using SchoolProject.Data.Entities;
using SchoolProject.Infrastructure.Abstracts;
using SchoolProject.Service.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Service.Implementations
{
    public class StudentService : IStudentService
    {
        #region Fields
        private readonly IStudentRepository _studentrepository;
        #endregion

        #region Constructors
        public StudentService(IStudentRepository studentrepository)
        {
            _studentrepository = studentrepository;
        }
        #endregion


        #region Handle Functions
        public async Task<List<Student>> GetStudentListAsync()
        {
            return await _studentrepository.GetStudentsListAsync();
        }
        #endregion



    }
}
