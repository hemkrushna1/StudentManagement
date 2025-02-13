using StudentManagement.DataAccess.Entities;

namespace StudentManagement.DataAccess.Interfaces
{
    public interface ISchoolClassRepository
    {
        Task<IEnumerable<SchoolClass>> Get();
    }
}
