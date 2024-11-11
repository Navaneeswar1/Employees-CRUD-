namespace assignment1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.SqlTypes;

    public partial class Employee
    {
        public  int EmployeeID { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        public string Designation { get; set; }
        public DateTime DOJ { get; set; }
        public string Salary { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        public string State { get; set; }
    }
}
