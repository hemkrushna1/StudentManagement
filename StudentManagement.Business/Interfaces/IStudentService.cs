using StudentManagement.Business.DTO;
namespace StudentManagement.Business.Interfaces
{
    public interface IStudentService
    {
        Task<List<StudentDTO>> Get();
    }
}
