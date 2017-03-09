using MVCEFDemo.Model;
using MVCEFDemo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCEFDemo.DAL
{
    public class JobPositionDAL
    {
        public static List<JobPositionsViewModel> GetAll()
        {
            List<JobPositionsViewModel> result = new List<JobPositionsViewModel>();
            using (EmployeeDataContext db = new EmployeeDataContext()) 
            {
                result = (from j in db.MSTJobPositions
                          select new JobPositionsViewModel
                          {
                              Id = j.Id,
                              Name = j.Name
                          }).ToList();
            }
            return result;
        }
    }
}
