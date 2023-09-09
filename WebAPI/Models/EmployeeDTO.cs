using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class CreateEmployeeDTO 
    {
        [Required]
        [StringLength(maximumLength:50, ErrorMessage ="First Name is too long")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string ProfileImageUrl { get; set; }
        public int? DepartmentId { get; set; }
    }

    public class EmployeeDTO : CreateEmployeeDTO
    {
        public int Id { get; set; }
        public DepartmentDTO Department { get; set; }
    }
}
