using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCEFDemo.Model
{
    [Table("MST_Employees")]
    public class MSTEmployees
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName="VARCHAR")]
        public string FirstName { get; set; }

        [Column(TypeName = "VARCHAR")]
        public string LastName { get; set; }

        [Column(TypeName = "VARCHAR")]
        public string Address { get; set; }

        [Column(TypeName = "VARCHAR")]
        public string Gender { get; set; }

        public int JobPositionId { get; set; }

        [Column(TypeName = "VARCHAR")]
        public string UserId { get; set; }

        [Column(TypeName = "VARCHAR")]
        public string Password { get; set; }
        public bool isActive { get; set; }
        public int? CreateBy { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? CreateOn { get; set; }

        public int? ModifiedBy { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ModifiedOn { get; set; }

        [ForeignKey("JobPositionId")]
        public virtual MSTJobPositions JobPosition { get; set; }
    }
}
