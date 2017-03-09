using MVCEFDemo.DAL;
using MVCEFDemo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEFDemo.Web.Controllers
{
    public class JobPositionsController : Controller
    {
        // GET: JobPositions
        public ActionResult Index()
        {
            return View(JobPositionDAL.GetAll());
        }
    }
}