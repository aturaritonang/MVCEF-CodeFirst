namespace MVCEFDemo03.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MST_JobPositions
    {
        public MST_JobPositions()
        {
            MST_Employees = new HashSet<MST_Employees>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateOn { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public virtual ICollection<MST_Employees> MST_Employees { get; set; }
    }
}
