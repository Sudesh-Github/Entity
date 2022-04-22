using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FBLCodeFrst.Models;

namespace FBLCodeFrst.Controllers
{
    public class Sample2Controller : Controller
    {
        Sample1Context db = new Sample1Context();
        public ActionResult Index()
        {
            db.MatchTable.ToList();
            return View();
        }
    }
}