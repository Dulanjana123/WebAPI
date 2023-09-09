using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Data
{
    public class Employee
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        public DateTime DOB { get; set; }
        public string ProfileImageUrl { get; set; }
        // Navigation property of Email entity
        public Department Department { get; set; }
        public int? DepartmentId { get; set; }
    }
}
