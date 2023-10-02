using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Demandas.Models;

namespace Demandas
{
    public class PermissaosController : Controller
    {
        private BancoContext db = new BancoContext();

        // GET: Permissaos
        public ActionResult Index()
        {
            return View(db.Permissoes.ToList());
        }

        // GET: Permissaos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Permissao permissao = db.Permissoes.Find(id);
            if (permissao == null)
            {
                return HttpNotFound();
            }
            return View(permissao);
        }

        // GET: Permissaos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Permissaos/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,TP_PERMISSAO,NM_CARGO,USUARIO_ID")] Permissao permissao)
        {
            if (ModelState.IsValid)
            {
                db.Permissoes.Add(permissao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(permissao);
        }

        // GET: Permissaos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Permissao permissao = db.Permissoes.Find(id);
            if (permissao == null)
            {
                return HttpNotFound();
            }
            return View(permissao);
        }

        // POST: Permissaos/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TP_PERMISSAO,NM_CARGO,USUARIO_ID")] Permissao permissao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(permissao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(permissao);
        }

        // GET: Permissaos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Permissao permissao = db.Permissoes.Find(id);
            if (permissao == null)
            {
                return HttpNotFound();
            }
            return View(permissao);
        }

        // POST: Permissaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Permissao permissao = db.Permissoes.Find(id);
            db.Permissoes.Remove(permissao);
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
