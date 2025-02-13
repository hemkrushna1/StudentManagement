using StudentManagement.Business.DTO;

namespace StudentManagement.Business.Interfaces
{
    public interface ISchoolClassService
    {
        Task<IEnumerable<SchoolClassDTO>> Get();
    }
}
