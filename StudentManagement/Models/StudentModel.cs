namespace StudentManagement.Models
{
    public class StudentModel
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string ParentName { get; set; }
        public string ParentEmail { get; set; }
        public string ParentMobile { get; set; }
        public bool Active { get; set; }
        public string ClassName { get; set; }

    }
}
