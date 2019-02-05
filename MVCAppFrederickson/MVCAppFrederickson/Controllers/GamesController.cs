using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAppFrederickson.Controllers
{
    public class GamesController : Controller
    {
        // GET: BrokenRobot
        public ActionResult BrokenRobot()
        {
            return View("../Games/BrokenRobot/Description");
        }
    }
}