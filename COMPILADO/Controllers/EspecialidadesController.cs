﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace COMPILADO.Controllers
{
    public class EspecialidadesController : Controller
    {
        // GET: Especialidades

        medicoEntities db = new medicoEntities();

        public ActionResult Index()
        {
            var especialidade = db.Especialidades.ToList();
            return View(especialidade);
        }

        public ActionResult Adicionar()
        {
            ViewBag.IDEspecialidade = new SelectList(db.Especialidades, "IDEspecialidades", "Especialidade");
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Especialidades especialidades)
        {
            if (ModelState.IsValid)
            {
                db.Especialidades.Add(especialidades);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDEspecialidade = new SelectList(db.Especialidades, "IDEspecialidade", "Especialidade");
            return View(especialidades);
        }

        public ActionResult Editar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Especialidades especialidades = db.Especialidades.Find(id);
            if (especialidades == null)
            {
                return HttpNotFound();
            }

            ViewBag.IDEspecialidade = new SelectList(db.Especialidades, "IDEspecialidade", "Especialidade");
            return View(especialidades);
        }

        [HttpPost]
        public ActionResult Editar(Especialidades especialidades)
        {

            if (ModelState.IsValid)
            {
                db.Entry(especialidades).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(especialidades);


        }

        public ActionResult Excluir(long? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Especialidades especialidade = db.Especialidades.Find(id);

            if (especialidade== null)
            {
                return HttpNotFound();
            }
            return View();
        }


        [HttpPost, ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public ActionResult Excluir(long id)
        {
            Especialidades especialidade = db.Especialidades.Find(id);
            db.Especialidades.Remove(especialidade);
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