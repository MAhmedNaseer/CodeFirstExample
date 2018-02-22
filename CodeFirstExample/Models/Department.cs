using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstExample.Models
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }
        [DisplayName("Description")]
        [Required(ErrorMessage = "This Field is Required")]
        [DataType(DataType.Text)]
        public string DepartmentDescription { get; set; }
        [ForeignKey("DepartmentID")]
        public ICollection<Employee> Employees { get; set; }

    }
}