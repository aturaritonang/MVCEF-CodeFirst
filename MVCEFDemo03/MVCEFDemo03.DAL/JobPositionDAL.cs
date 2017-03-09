using MVCEFDemo03.Model;
using MVCEFDemo03.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCEFDemo03.DAL
{
    public class JobPositionDAL
    {
        public static List<JobPositionsViewModel> GetAll()
        {
            List<JobPositionsViewModel> result = new List<JobPositionsViewModel>();
            using (EmplDataContext db = new EmplDataContext())
            {
                result = (from j in db.MST_JobPositions
                          select new JobPositionsViewModel
                          {
                              Id = j.Id,
                              Name = j.Name
                          }).ToList();
            }
            return result;
        }

        public static JobPositionsViewModel GetById(int id) 
        {
            JobPositionsViewModel result = new JobPositionsViewModel();
            using (EmplDataContext db = new EmplDataContext()) 
            {
                result = (from j in db.MST_JobPositions
                          where j.Id == id
                          select new JobPositionsViewModel
                          {
                              Id = j.Id,
                              Name = j.Name
                          }).FirstOrDefault();
            }
            return result;
        }

        public static bool Add(JobPositionsViewModel model) 
        {
            bool result = false;
            using (EmplDataContext db = new EmplDataContext()) 
            {
                MST_JobPositions mstJobPosition = new MST_JobPositions();
                mstJobPosition.Name = model.Name;

                try
                {
                    db.MST_JobPositions.Add(mstJobPosition);
                    db.SaveChanges();
                    result = true;
                }
                catch 
                {
                    result = false;
                }
            }
            return result;
        }

        public static bool Update(JobPositionsViewModel model) 
        {
            bool result = false;
            using (EmplDataContext db = new EmplDataContext()) 
            {
                MST_JobPositions mstJobPosition = db.MST_JobPositions.Where(x => x.Id == model.Id).FirstOrDefault();
                mstJobPosition.Name = model.Name;
                mstJobPosition.ModifiedBy = 1;
                mstJobPosition.ModifiedOn = DateTime.Now;

                try
                {
                    db.SaveChanges();
                    result = true;
                }
                catch 
                {
                    result = false;
                }
            }
            return result;
        }

        public static bool Delete(int id) 
        {
            bool result = false;
            using (EmplDataContext db = new EmplDataContext()) 
            {
                MST_JobPositions mstJobPosition = db.MST_JobPositions.Where(x => x.Id == id).FirstOrDefault();
                try
                {
                    db.MST_JobPositions.Remove(mstJobPosition);
                    db.SaveChanges();
                    result = true;
                }
                catch 
                {
                    result = false;
                }
            }
            return result;
        }
    }
}
