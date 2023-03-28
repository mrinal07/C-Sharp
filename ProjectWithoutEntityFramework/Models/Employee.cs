﻿namespace ProjectWithoutEntityFramework.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }
        public DateTime HireDate { get; set; }
        public int Salary { get; set; }
    }
}
