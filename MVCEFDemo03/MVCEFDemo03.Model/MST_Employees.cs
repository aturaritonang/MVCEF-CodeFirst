namespace MVCEFDemo03.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MST_Employees
    {
        public int Id { get; set; }

        [StringLength(8000)]
        public string FirstName { get; set; }

        [StringLength(8000)]
        public string LastName { get; set; }

        [StringLength(8000)]
        public string Address { get; set; }

        [StringLength(8000)]
        public string Gender { get; set; }

        public int JobPositionId { get; set; }

        [StringLength(8000)]
        public string UserId { get; set; }

        [StringLength(8000)]
        public string Password { get; set; }

        public bool isActive { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public virtual MST_JobPositions MST_JobPositions { get; set; }
    }
}
