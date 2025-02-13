﻿namespace StudentManagement.DataAccess.Entities
{
    public class ParentStudent
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int StudentId { get; set; }

        public User Parent { get; set; }
        public User Student { get; set; }

    }
}
