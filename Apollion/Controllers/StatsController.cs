using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Apollion.Controllers
{
    public class StatsController : Controller
    {
        // GET: Stats
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PVP()
        {
            return View();
        }
        public ActionResult PVE()
        {
            return View();
        }
    }
}