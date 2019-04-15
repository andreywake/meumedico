using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COMPILADO.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Especialidade()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }


        public ActionResult consulta()
        {
            return View();
        }
    }
}