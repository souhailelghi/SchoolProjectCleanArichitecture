using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using SchoolProject.Infrastructure.Abstracts;
using SchoolProject.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        #region Fields
        private readonly ApplecationDBContext _dbContext;

        #endregion

        #region Constructors
        public StudentRepository(ApplecationDBContext DBContext)
        {
            _dbContext = DBContext;
        }
        #endregion


        #region Handlers Functions
        public async Task<List<Student>> GetStudentsListAsync()
        {
            return await _dbContext.Students.ToListAsync();
        }
        #endregion

    }
}
