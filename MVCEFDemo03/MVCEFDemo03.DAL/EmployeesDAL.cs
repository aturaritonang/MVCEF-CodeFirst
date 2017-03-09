using MVCEFDemo03.Model;
using MVCEFDemo03.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCEFDemo03.DAL
{
    public class EmployeesDAL
    {
        public static List<EmployeesViewModel> GetAll() 
        {
            List<EmployeesViewModel> result = new List<EmployeesViewModel>();
            using (EmplDataContext db = new EmplDataContext()) {
                result = (from e in db.MST_Employees
                          join j in db.MST_JobPositions on e.JobPositionId equals j.Id
                          select new EmployeesViewModel
                          {
                              Id = e.Id,
                              FirstName = e.FirstName,
                              LastName = e.LastName,
                              Gender = e.Gender,
                              JobPositionId = e.JobPositionId,
                              JobPositionName = j.Name,
                              UserId = e.UserId,
                              Password = e.Password,
                              isActive = e.isActive
                          }).ToList();
            }
            return result;
        }

        public static EmployeesViewModel GetById(int id)
        {
            EmployeesViewModel result = new EmployeesViewModel();
            using (EmplDataContext db = new EmplDataContext())
            {
                result = (from e in db.MST_Employees
                          join j in db.MST_JobPositions on e.JobPositionId equals j.Id
                          where e.Id == id 
                          select new EmployeesViewModel
                          {
                              Id = e.Id,
                              FirstName = e.FirstName,
                              LastName = e.LastName,
                              Gender = e.Gender,
                              JobPositionId = e.JobPositionId,
                              JobPositionName = j.Name,
                              UserId = e.UserId,
                              Password = e.Password,
                              isActive = e.isActive
                          }).FirstOrDefault();
            }
            return result;
        }

        public static bool Add(EmployeesViewModel model) 
        {
            bool result = false;
            using (EmplDataContext db = new EmplDataContext())
            {
                MST_Employees mstEmployee = new MST_Employees();
                mstEmployee.FirstName = model.FirstName;
                mstEmployee.LastName = model.LastName;
                mstEmployee.Gender = model.Gender;
                mstEmployee.JobPositionId = model.JobPositionId;
                mstEmployee.UserId = model.UserId;
                mstEmployee.Password = model.Password;
                mstEmployee.isActive = model.isActive;

                try
                {
                    db.MST_Employees.Add(mstEmployee);
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

        public static bool Update(EmployeesViewModel model)
        {
            bool result = false;
            using (EmplDataContext db = new EmplDataContext())
            {
                MST_Employees mstEmployee = db.MST_Employees.Where(x => x.Id == model.Id).FirstOrDefault();
                mstEmployee.FirstName = model.FirstName;
                mstEmployee.LastName = model.LastName;
                mstEmployee.Gender = model.Gender;
                mstEmployee.JobPositionId = model.JobPositionId;
                mstEmployee.UserId = model.UserId;
                mstEmployee.Password = model.Password;
                mstEmployee.isActive = model.isActive;
                mstEmployee.ModifiedBy = 1;
                mstEmployee.ModifiedOn = DateTime.Now;

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
                MST_Employees mstEmployee = db.MST_Employees.Where(x => x.Id == id).FirstOrDefault();
                try
                {
                    db.MST_Employees.Remove(mstEmployee);
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
