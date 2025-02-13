using StudentManagement.DataAccess.Entities;
using StudentManagement.DataAccess.Interfaces;
using StudentManagement.Business.Interfaces;
using StudentManagement.Business.DTO;
using AutoMapper;
using System.Linq.Expressions;

namespace StudentManagement.Business.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<UserDTO> Get(int id)
        {
            var user = await _userRepository.Get(id);

            var userDTO = _mapper.Map<UserDTO>(user);

            return userDTO;
        }

        public async Task<UserDTO> Update(UserDTO userDTO)
        {
            var user = _mapper.Map<User>(userDTO);

            user = await _userRepository.Update(user);

            userDTO = _mapper.Map<UserDTO>(user);

            return userDTO;
        }

        public async Task<UserDTO> Update(int id, bool active)
        {
            UserDTO userDTO = null;
            var user = await _userRepository.Get(id);

            if (user != null)
            {
                user.Active = active;

                user = await _userRepository.Update(user);

                userDTO = _mapper.Map<UserDTO>(user);
            }

            return userDTO;
        }

        public async Task<bool> Exists(int id)
        {
            return await _userRepository.Exists(id);
        }
    }
}
