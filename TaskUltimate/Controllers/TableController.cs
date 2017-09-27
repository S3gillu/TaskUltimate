using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskUltimate.Models;

namespace TaskUltimate.Controllers
{
    public class TableController : Controller
    {
        // GET: Table
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData()
        {
            using (TraineeContext db = new TraineeContext())
            {
                var WorkerData = db.TraineeVMs.OrderBy(a => a.Name).ToList();
                return Json(new { data = WorkerData }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}