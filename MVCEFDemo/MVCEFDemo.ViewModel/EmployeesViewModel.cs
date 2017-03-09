using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCEFDemo.ViewModel
{
    public class EmployeesViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public int JobPositionId { get; set; }
        public int JobPositionName { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public bool isActive { get; set; }
    }
}
