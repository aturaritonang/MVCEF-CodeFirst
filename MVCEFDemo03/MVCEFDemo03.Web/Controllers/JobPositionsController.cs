using MVCEFDemo03.DAL;
using MVCEFDemo03.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEFDemo03.Web.Controllers
{
    public class JobPositionsController : Controller
    {
        // GET: JobPositions
        public ActionResult Index()
        {
            return View(JobPositionDAL.GetAll());
        }

        public ActionResult Details(int id) 
        {
            return View(JobPositionDAL.GetById(id));
        }

        public ActionResult Create() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(JobPositionsViewModel model)
        {
            if (JobPositionDAL.Add(model))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult Edit(int id) 
        {
            return View(JobPositionDAL.GetById(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(JobPositionsViewModel model) 
        {
            if (JobPositionDAL.Update(model))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult Delete(int id) 
        {
            return View(JobPositionDAL.GetById(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(JobPositionsViewModel model)
        {
            if (JobPositionDAL.Delete(model.Id))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(JobPositionDAL.GetById(model.Id));
            }
        }
    }
}