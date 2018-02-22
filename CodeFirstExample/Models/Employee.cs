using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstExample.Models
{
    public class Employee
    {
        [Key]
        [DisplayName("Employee ID")]
        public int EmployeeID { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "This Field is Required")]
        public string Name { get; set; }

        [DisplayName("Contact")]
        [Required(ErrorMessage = "This Field is Required")]
        public string Contact { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "This Field is Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DisplayName("Password")]
        [Required(ErrorMessage = "This Field is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        public int DepartmentID { get; set; }
        [DisplayName("DepartmentID")]
      //  [Required(ErrorMessage = "This Field is Required")]
        public Department Department { get; set; }
    }
}