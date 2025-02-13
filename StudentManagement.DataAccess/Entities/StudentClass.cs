namespace StudentManagement.DataAccess.Entities
{
    public class StudentClass
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }

        public User UserStudent { get; set; }
        public SchoolClass? SchoolClass { get; set; }

    }
}
