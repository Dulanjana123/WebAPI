using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Data
{
    public class User
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string? UserName { get; set; }

        [MaxLength(100)]
        public string? Password { get; set; }

        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }

        [MaxLength(50)]
        public string FullName { get; set; }

        [MaxLength(50)]
        public string? EmailAddress { get; set; }
        [MaxLength(30)]
        public string? ContactNo { get; set; }
    }
}
