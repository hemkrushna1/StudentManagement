using Microsoft.EntityFrameworkCore;
using StudentManagement.DataAccess.Entities;
using StudentManagement.DataAccess.Interfaces;

namespace StudentManagement.DataAccess.Repositories
{
    public class SchoolClassRepository : BaseRepository<SchoolClass>, ISchoolClassRepository
    {
        private readonly EfContext _efContext;

        public SchoolClassRepository(EfContext efContext) : base(efContext) {
            _efContext = efContext;
        }

        public async Task<IEnumerable<SchoolClass>> Get()
        {
            var schoolClasses = await base.GetAllAsync();

            return schoolClasses;
        }
    }
}
