using Microsoft.EntityFrameworkCore;
using StudentManagement.DataAccess.Entities;
using StudentManagement.DataAccess.Interfaces;

namespace StudentManagement.DataAccess.Repositories
{
    public class ParentStudentRepository : BaseRepository<StudentClass>, IParentStudentRepository
    {
        private readonly EfContext _efContext;

        public ParentStudentRepository(EfContext efContext) : base(efContext) {
            _efContext = efContext;
        }

        public async Task<List<ParentStudent>> Get()
        {
            var students = await _efContext.ParentStudents
                .Include(ps => ps.Student)
                .Include(ps => ps.Parent)
                .Include(ps => ps.Student.Students)
                .ThenInclude(sc => sc.SchoolClass)
                .ToListAsync();

            return students;
        }
    }
}
