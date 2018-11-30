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

            var hero = db.SuperHero.Find(id);
            return View(hero);
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
            var hero = db.SuperHero.Find(id);
            return View(hero);
        }

        // POST: SuperHero/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, [Bind(Include = "SuperHeroID,SuperHeroName,AlterEgo,PrimarySuperHeroAbility,SecondarySuperHeroAbility,CatchPhrase")] SuperHero MyHeroNew)
        {
            try
            {
                // TODO: Add update logic here
                SuperHero MyHeroOld = db.SuperHero.Find(id);
                MyHeroOld.SuperHeroName = MyHeroNew.SuperHeroName;
                MyHeroOld.AlterEgo = MyHeroNew.AlterEgo;
                MyHeroOld.PrimarySuperHeroAbility = MyHeroNew.PrimarySuperHeroAbility;
                MyHeroOld.SecondarySuperHeroAbility = MyHeroNew.SecondarySuperHeroAbility;
                MyHeroOld.CatchPhrase = MyHeroNew.CatchPhrase;
                db.SaveChanges();
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
            var hero = db.SuperHero.Find(id);
            return View(hero);
        }

        // POST: SuperHero/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, SuperHero hero)
        {
            try
            {
                // TODO: Add delete logic here
                hero = db.SuperHero.Find(id);
                db.SuperHero.Remove(hero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
