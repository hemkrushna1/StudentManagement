using StudentManagement.Business.DTO;
using StudentManagement.Business.Interfaces;
using StudentManagement.Core.Extensions;
using StudentManagement.DataAccess.Interfaces;

namespace StudentManagement.Business.Services
{
    public class StudentService : IStudentService
    {
        private readonly IParentStudentRepository _parentStudentRepository;

        public StudentService(IParentStudentRepository parentStudentRepository) 
        {
            _parentStudentRepository = parentStudentRepository;
        }

        public async Task<List<StudentDTO>> Get()
        {
            var parentStudents = await _parentStudentRepository.Get();

            var studentDto = parentStudents.Select(ps => new StudentDTO
            {
                StudentId = ps.Student.Id,
                StudentName = ps.Student.FirstName.ConcatWith(ps.Student.LastName, " "),
                ParentName = ps.Parent.FirstName.ConcatWith(ps.Parent.LastName, " "),
                ParentEmail = ps.Parent.Email,
                ParentMobile = ps.Parent.Phone,
                Active = ps.Student.Active,
                ClassName = ps.Student.Students.FirstOrDefault()?.SchoolClass.Name
            }).ToList();

            return studentDto;
        }
    }
}
