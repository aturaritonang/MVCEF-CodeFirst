using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCEFDemo.Model
{
    public class EmployeeDataContext: DbContext
    {
        public EmployeeDataContext():base("Name=EmployeeDBConn")
        {
            Database.SetInitializer(new EmployeeDBInitializer());
        }

        public virtual DbSet<MSTJobPositions> MSTJobPositions { get; set; }
        public virtual DbSet<MSTEmployees> MSTEmployees { get; set; }
    }
}
