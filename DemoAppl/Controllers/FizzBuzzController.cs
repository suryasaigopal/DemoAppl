using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoAppl.Controllers
{
    public class FizzBuzzController : Controller
    {
        // GET: FizzBuzz
        FizzbuzzClass oFizz = new FizzbuzzClass();
        public ActionResult Index()
        {
            List<string> lstfizzbuzz = oFizz.logicFizzBuzz();
            ViewBag.collectionFizzBuzz = lstfizzbuzz;
            return View();
        }
    }
}