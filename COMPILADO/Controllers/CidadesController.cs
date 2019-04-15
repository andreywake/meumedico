using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace COMPILADO.Controllers
{
    public class CidadesController : Controller
    {
        // GET: Cidades
        medicoEntities db = new medicoEntities();

        public ActionResult Index()
        {
            var cidade = db.Cidades.ToList();
            return View(cidade);
        }

        public ActionResult Adicionar()
        {
            ViewBag.IDCidade = new SelectList(db.Cidades,"IDCidade","Cidade");
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Cidades cidades )
        {
            if (ModelState.IsValid)
            {
                db.Cidades.Add(cidades);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDCidade = new SelectList(db.Cidades, "IDCidade", "Cidade");
            ViewBag.IDEstados = new SelectList(db.Estados,"IDEstado","Estados");
            return View(cidades);
        }

        public ActionResult Editar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Cidades cidades = db.Cidades.Find(id);
            if (cidades == null)
            {
                return HttpNotFound();
            }

            ViewBag.IDCidade = new SelectList(db.Cidades, "IDCidade", "Cidade");
            return View(cidades);
        }

        [HttpPost]
        public ActionResult Editar(Cidades cidades)
        {

            if (ModelState.IsValid)
            {
                db.Entry(cidades).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cidades);


        }

        public ActionResult Excluir(long? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Cidades cidades = db.Cidades.Find(id);

            if (cidades == null)
            {
                return HttpNotFound();
            }
            return View();
        }


        [HttpPost, ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public ActionResult Excluir(long id)
        {
            Cidades cidades = db.Cidades.Find(id);
            db.Cidades.Remove(cidades);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);

        }

    }
}