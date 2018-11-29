using Hero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hero.Controllers
{
    public class SuperHeroController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: SuperHero
        public ActionResult Index()
        {
            List<SuperHero> SuperHeroes = new List<SuperHero>();
            SuperHeroes = db.SuperHero.ToList();
            return View(SuperHeroes);
        }

        // GET: SuperHero/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SuperHero/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperHero/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "SuperHeroID,SuperHeroName,AlterEgo,PrimarySuperHeroAbility,SecondarySuperHeroAbility,CatchPhrase")] SuperHero MyHero)
        {
            try
            {
                // TODO: Add insert logic her
                db.SuperHero.Add(MyHero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(MyHero);
            }
        }

        // GET: SuperHero/Edit/5
        public ActionResult Edit(int id)
        {
            
            return View();
        }

        // POST: SuperHero/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHero/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SuperHero/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
