using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Payroll_Mvc.Models;

namespace Payroll_Mvc.Controllers
{
    public class countryController : Controller
    {
        // GET: country
        public ActionResult Index()
        {
            PayrollContext db = new PayrollContext();
            country Country = db.Country.Single(x => x.Id == 1);
            return View(Country);
        }
    }
}