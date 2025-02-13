using StudentManagement.Business.DTO;
using StudentManagement.DataAccess.Entities;

namespace StudentManagement.Business.Interfaces
{
    public interface IUserService
    {
        Task<UserDTO> Get(int id);

        Task<UserDTO> Update(UserDTO user);

        Task<UserDTO> Update(int id, bool active);

        Task<bool> Exists(int id);
    }
}
