using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Apollion.Models;

namespace Apollion.Controllers
{
    public class StatsController : Controller
    {
        // GET: Stats
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PVE()
        {
            var model = new StatsViewModel();

            for (var i = 0; i < 6; i++)
            {
                model.Value.Add(i);
            }

            return View(model);
        }

        public ActionResult PVP()
        {
            var model = new StatsViewModel();

            for (var i = 0; i < 6; i++)
            {
                model.Value.Add(i);
            }

            return View(model);
        }
    }
}