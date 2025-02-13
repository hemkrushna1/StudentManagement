using StudentManagement.DataAccess.Entities;
namespace StudentManagement.DataAccess.Interfaces
{
    public interface IUserRepository
    {
        Task<User> Get(int id);

        Task<User> Update(User user);

        Task<bool> Exists(int id);
    }
}
