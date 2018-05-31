using System;
using System.Collections.Generic;
using Apoteket.UppgiftBE.Web.Context;
using Apoteket.UppgiftBE.Web.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Apoteket.UppgiftBE.Web.Controllers
{
    public class BasketController : Controller
    {

        // GET: Basket
        private ProductDbContext db = new ProductDbContext();
     
        public ActionResult Index()
        {
            var baskets = db.Baskets.ToList();
            return View(baskets);
        }

        // GET: Basket/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Basket basket = db.Baskets.Find(id);
           

            if (basket == null)
            {
                return HttpNotFound();
            }
            return RedirectToAction("Index", "Home");
        }

        // GET: Basket/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Basket/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Price,NumberOfOrder")] Basket basket)
        {
            if (ModelState.IsValid)
            {
                var rnd = new Random();
                basket.NumberOfOrder = rnd.Next(1, 100);
                basket.Price = db.Products.Sum(p => p.Price);
                db.Baskets.Add(basket);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(basket);
        }

        // GET: Basket/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Basket basket = db.Baskets.Find(id);
            if (basket == null)
            {
                return HttpNotFound();
            }
            return View(basket);
        }

        // POST: Basket/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Price,NumberOfOrder")] Basket basket)
        {
            if (ModelState.IsValid)
            {
                db.Entry(basket).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(basket);
        }


        // GET: Basket/Delete/5
        public ActionResult Delete(int id)
        {
            Basket basket = db.Baskets.Find(id);
            if (basket == null)
            {
                return HttpNotFound();
            }
            return View(basket);
        }

        // POST: Basket/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Basket basket = db.Baskets.Find(id);
            if (basket != null) db.Baskets.Remove(basket);
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

        public ActionResult Checkout(int id)
        {
            var basket = db.Baskets.Find(id);
            if (basket == null)
            {
                return HttpNotFound();
            }
            if (basket != null) db.Baskets.Remove(basket);
            db.SaveChanges();
            return View(basket);
        }
    }
}
