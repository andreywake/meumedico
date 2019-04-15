using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COMPILADO.Models;
using System.Data.Entity;
using System.Net;


namespace COMPILADO.Controllers
{
    public class usuarioController : Controller
    {
        // GET: usuario

        medicoEntities db = new medicoEntities();

        public ActionResult Index()
        {
            return View();
        }
    }
}