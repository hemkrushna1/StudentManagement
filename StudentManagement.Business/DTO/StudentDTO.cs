using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Business.DTO
{
    public class StudentDTO
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
