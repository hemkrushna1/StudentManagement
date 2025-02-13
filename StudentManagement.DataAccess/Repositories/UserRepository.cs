using Microsoft.EntityFrameworkCore;
using StudentManagement.Core.Enum;
using StudentManagement.DataAccess.Entities;
using StudentManagement.DataAccess.Interfaces;
using System.Linq.Expressions;

namespace StudentManagement.DataAccess.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly EfContext _efContext;

        public UserRepository(EfContext efContext) : base(efContext)
        {
            _efContext = efContext;
        }

        public async Task<User> Get(int id)
        {
            var user = await _efContext.Users
            .Include(u => u.Students)
            .ThenInclude(sc => sc.SchoolClass)
            .FirstOrDefaultAsync(u => u.Id == id && u.UserType == UserType.Student);

            return user;
        }

        public async Task<User> Update(User user)
        {
            user = await base.UpdateAsync(user);

            return user;
        }

        public async Task<bool> Exists(int id)
        {
            return await base.ExistsAsync(u => u.Id == id);
        }
    }
}
