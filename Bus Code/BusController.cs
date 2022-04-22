using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusDemo.Models;

namespace BusDemo.Controllers
{
    public class BusController : Controller
    {
        BusDbContext db = new BusDbContext();   
        public ActionResult Index()
        {
            db.BusDetailsTable.ToList();
            return View();
        }
    }
}