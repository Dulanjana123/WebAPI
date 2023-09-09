using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class CreateDepartmentDTO
    {
        public string Name { get; set; }
    }
    public class DepartmentDTO : CreateDepartmentDTO
    {
        public int Id { get; set; }
        public IList<EmployeeDTO> Employees { get; set; }
    }
}
