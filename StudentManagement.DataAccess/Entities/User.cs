using Microsoft.EntityFrameworkCore;
using StudentManagement.Core.Enum;

namespace StudentManagement.DataAccess.Entities
{
    public class User
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
