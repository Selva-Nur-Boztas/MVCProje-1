using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProje.Controllers
{
    public class testController : Controller
    {
        // GET: test
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult test2()
        {
            return View();
        }    
            
    }
}