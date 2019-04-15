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
    public class meumedicoController : Controller
    {
        // GET: meumedico

        private medicoEntities db = new medicoEntities();
      
        public ActionResult Index()
        {
            var medico = db.Medicos.Include(m => m.Cidades).Include(m => m.Especialidades).ToList();
            return View(medico);
        }

        public ActionResult Adicionar()
        {
            ViewBag.IDCidade = new SelectList(db.Cidades, "IDCidade", "Cidade");
            ViewBag.IDEspecialidade = new SelectList(db.Especialidades, "IDEspecialidade", "Especialidade");

            return View();
        }


        [HttpPost]
        public ActionResult Adicionar(Medicos medicos)
        {
            if (ModelState.IsValid)
            {
                db.Medicos.Add(medicos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDCidade = new SelectList(db.Cidades, "IDCidade", "Cidade",medicos.IDCidade);
            ViewBag.IDEspecialidade = new SelectList(db.Especialidades, "IDEspecialidade", "Especialidade",medicos.IDEspecialidade);
            return View(medicos);
        }


        public ActionResult Editar (int? id)
        {
            Medicos medicos = db.Medicos.Find(id);
            ViewBag.IDCidade = new SelectList(db.Cidades, "IDCidade", "Cidade", medicos.IDCidade);
            ViewBag.IDEspecialidade = new SelectList(db.Especialidades,"IDEspecialidade","Especialidade",medicos.IDEspecialidade);
            return View(medicos);
        }

        [HttpPost]
        public ActionResult Editar (Medicos medicos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(medicos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(medicos);
        }


        public ActionResult Excluir(long? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Medicos medicos = db.Medicos.Find(id);

            if(medicos == null)
            {
                return HttpNotFound();
            }
            return View();
        }


        [HttpPost,ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public ActionResult Excluir (long id)
        {
            Medicos medicos = db.Medicos.Find(id);
            db.Medicos.Remove(medicos);
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