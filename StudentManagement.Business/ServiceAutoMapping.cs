using AutoMapper;
using StudentManagement.Business.DTO;
using StudentManagement.DataAccess.Entities;

namespace StudentManagement.Business
{
    public class ServiceAutoMapping : Profile
    {
        public ServiceAutoMapping()
        {
            CreateMap<UserDTO, User>().ReverseMap();
            CreateMap<SchoolClassDTO, SchoolClass>().ReverseMap();
        }
    }
}
