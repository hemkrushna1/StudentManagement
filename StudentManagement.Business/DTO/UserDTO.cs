using StudentManagement.Core.Enum;
using StudentManagement.DataAccess.Entities;

namespace StudentManagement.Business.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserType UserType { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }


        public List<StudentClass> Students { get; set; }
    }
}
