using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace WebApplicationDemo.Models
{
    public class EmployeeViewModel
    {
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0,60,ErrorMessage ="Please Enter valid age")]
        public string Age { get; set; }
        [Required]
        public string Salary { get; set; }

        public string Designation { get; set; }

        public int Gender { get; set; }

    }
}
