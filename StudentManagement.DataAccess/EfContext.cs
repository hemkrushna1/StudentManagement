using Microsoft.EntityFrameworkCore;
using StudentManagement.DataAccess.Entities;

namespace StudentManagement.DataAccess
{
    public class EfContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<SchoolClass> SchoolClasses { get; set; }
        public DbSet<ParentStudent> ParentStudents { get; set; }
        public DbSet<StudentClass> StudentClasses { get; set; }

        public EfContext(DbContextOptions<EfContext> options) : base(options) { }
    }
}
