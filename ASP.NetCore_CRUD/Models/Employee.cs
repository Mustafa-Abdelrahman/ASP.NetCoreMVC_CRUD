using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetCore_CRUD.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        
        [StringLength(50)]
        [DisplayName("Emp. Code")]
        public string EmployeeCode { get; set; }

        [StringLength(250)]
        [Required(ErrorMessage ="This field is required.")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }

        [StringLength(100)]
        public string Position { get; set; }

        [DisplayName("Office Location")]
        [StringLength(50)]
        public string OfficeLocation { get; set; }

    }
}
