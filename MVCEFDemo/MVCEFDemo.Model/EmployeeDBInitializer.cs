using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCEFDemo.Model
{
    public class EmployeeDBInitializer: DropCreateDatabaseAlways<EmployeeDataContext>
    {
        public EmployeeDBInitializer()
        {
        }

        public override void InitializeDatabase(EmployeeDataContext context)
        {
            base.InitializeDatabase(context);
        }

        protected override void Seed(EmployeeDataContext context)
        {
            IList<MSTJobPositions> JobPositions = new List<MSTJobPositions>();
            JobPositions.Add(new MSTJobPositions() { Id = 1, Name = "Programmer" });
            JobPositions.Add(new MSTJobPositions() { Id = 2, Name = "System Analyst" });
            JobPositions.Add(new MSTJobPositions() { Id = 3, Name = "Business Analyst" });
            JobPositions.Add(new MSTJobPositions() { Id = 4, Name = "Project Manager" });
            JobPositions.Add(new MSTJobPositions() { Id = 5, Name = "Quality Assurance" });

            foreach (MSTJobPositions item in JobPositions)
            {
                context.MSTJobPositions.Add(item);
            }

            IList<MSTEmployees> Employees = new List<MSTEmployees>();

            base.Seed(context);
        }
    }
}
