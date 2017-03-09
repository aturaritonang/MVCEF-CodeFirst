using MVCEFDemo03.DAL;
using MVCEFDemo03.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEFDemo03.Web.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            return View(EmployeesDAL.GetAll());
        }

        public ActionResult Create()
        {
            ViewBag.JobPosList = new SelectList(JobPositionDAL.GetAll(), "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeesViewModel model) 
        {
            if (EmployeesDAL.Add(model))
            {
                return RedirectToAction("Index");
            }
            else 
            {
                return View(model);
            }
        }
    }
}