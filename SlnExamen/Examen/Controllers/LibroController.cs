using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BEUExamen;
using BEUExamen.Transactions;

namespace Examen.Controllers
{
    public class LibroController : Controller
    {
        //private Entities db = new Entities();

        // GET: Libro
        public ActionResult Index()
        {
            //return View(db.Libro.ToList());
            return View(LibroBLL.List());
        }

        // GET: Libro/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Libro libro = db.Libro.Find(id);
            Libro libro = LibroBLL.Get(id);
            if (libro == null)
            {
                return HttpNotFound();
            }
            return View(libro);
        }

        // GET: Libro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Libro/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idlibro,titulo,autor,ISBN,fecha_publicacion,nejemplares,categoria")] Libro libro)
        {
            if (ModelState.IsValid)
            {
                LibroBLL.Create(libro);
                return RedirectToAction("Index");
            }

            return View(libro);
        }

        // GET: Libro/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
           Libro libro = LibroBLL.Get(id);
            if (libro == null)
            {
                return HttpNotFound();
            }
            return View(libro);
        }

        // POST: Libro/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idlibro,titulo,autor,ISBN,fecha_publicacion,nejemplares,categoria")] Libro libro)
        {
            if (ModelState.IsValid)
            {
                LibroBLL.Update(libro);
                return RedirectToAction("Index");
            }
            return View(libro);
        }

        // GET: Libro/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Libro libro = LibroBLL.Get(id);
            if (libro == null)
            {
                return HttpNotFound();
            }
            return View(libro);
        }

        // POST: Libro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
           LibroBLL.Delete(id);
            return RedirectToAction("Index");
        }

      
    }
}
