using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCEFDemo.Model
{
    [Table("MST_JobPositions")]
    public class MSTJobPositions
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        public int? CreateBy { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? CreateOn { get; set; }

        public int? ModifiedBy { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ModifiedOn { get; set; }

        public virtual ICollection<MSTEmployees> Employees { get; set; }
    }
}
