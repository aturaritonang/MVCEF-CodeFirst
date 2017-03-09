using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCEFDemo03.ViewModel
{
    public class EmployeesViewModel
    {
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public int JobPositionId { get; set; }
        [DisplayName("Job Position")]
        public string JobPositionName { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public bool isActive { get; set; }
    }
}
