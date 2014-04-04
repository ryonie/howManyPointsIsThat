using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HowManyPointsIsThat.Entities;
using HowManyPointsIsThat.Web.Models;

namespace HowManyPointsIsThat.Web.Controllers
{
    public class FoodItemController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /FoodItem/
        public async Task<ActionResult> Index()
        {
            return View(await db.FoodItems.ToListAsync());
        }

        // GET: /FoodItem/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodItem fooditem = await db.FoodItems.FindAsync(id);
            if (fooditem == null)
            {
                return HttpNotFound();
            }
            return View(fooditem);
        }

        // GET: /FoodItem/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /FoodItem/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include="FoodItemId,Name,Brand,Fiber,Fat,Calories,Protein,Points,Carbohydrates,ServingWeight,ServingQty,ServingUnit,ServingsPerContainer")] FoodItem fooditem)
        {
            if (ModelState.IsValid)
            {
                db.FoodItems.Add(fooditem);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(fooditem);
        }

        // GET: /FoodItem/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodItem fooditem = await db.FoodItems.FindAsync(id);
            if (fooditem == null)
            {
                return HttpNotFound();
            }
            return View(fooditem);
        }

        // POST: /FoodItem/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include="FoodItemId,Name,Brand,Fiber,Fat,Calories,Protein,Points,Carbohydrates,ServingWeight,ServingQty,ServingUnit,ServingsPerContainer")] FoodItem fooditem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fooditem).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(fooditem);
        }

        // GET: /FoodItem/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodItem fooditem = await db.FoodItems.FindAsync(id);
            if (fooditem == null)
            {
                return HttpNotFound();
            }
            return View(fooditem);
        }

        // POST: /FoodItem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            FoodItem fooditem = await db.FoodItems.FindAsync(id);
            db.FoodItems.Remove(fooditem);
            await db.SaveChangesAsync();
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
