using AutoMapper;
using StudentManagement.Business.DTO;

namespace StudentManagement.Models
{
    public class ModelAutoMapping: Profile
    {
        public ModelAutoMapping()
        {
            CreateMap<StudentModel, StudentDTO>().ReverseMap();
            CreateMap<UserModel, UserDTO>().ReverseMap();
        }
    }
}
