using StudentManagement.DataAccess.Entities;
using StudentManagement.DataAccess.Interfaces;
using StudentManagement.Business.Interfaces;
using StudentManagement.Business.DTO;
using AutoMapper;

namespace StudentManagement.Business.Services
{
    public class SchoolClassService : ISchoolClassService
    {
        private readonly IMapper _mapper;
        private readonly ISchoolClassRepository _schoolclassRepository;

        public SchoolClassService(IMapper mapper, ISchoolClassRepository schoolclassRepository)
        {
            _mapper = mapper;
            _schoolclassRepository = schoolclassRepository;
        }

        public async Task<IEnumerable<SchoolClassDTO>> Get()
        {
            var classes = await _schoolclassRepository.Get();

            var classesDTO = _mapper.Map<IEnumerable<SchoolClassDTO>>(classes);

            return classesDTO;
        }
    }
}
