using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project_1_Overwatch.Models;

namespace Project_1_Overwatch.Controllers
{
    public class HeroesController : Controller
    {
        private OverwatchGuidesEntities1 db = new OverwatchGuidesEntities1();

        // GET: Heroes
        public async Task<ActionResult> Index()
        {
            return View(await db.Heroes.ToListAsync());
        }

        // GET: Heroes/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hero hero = await db.Heroes.FindAsync(id);
            if (hero == null)
            {
                return HttpNotFound();
            }

            char delimiter = '*';
            String strengths;
            String weaknesses;
            String counters;
            String counteredby;
            String synergy;
            String discord;

            if (hero.Strengths == null)
            {
                strengths = "None";
            }
            else
            {
                strengths = hero.Strengths;
            }

            if (hero.Weaknesses == null)
            {
                weaknesses = "None";
            }
            else
            {
                weaknesses = hero.Weaknesses;
            }

            if (hero.Counters == null)
            {
                counters = "None";
            }
            else
            {
                counters = hero.Counters;
            }

            if (hero.Counteredby == null)
            {
                counteredby = "None";
            }
            else
            {
                counteredby = hero.Counteredby;
            }

            if (hero.Synergy == null)
            {
                synergy = "None";
            }
            else
            {
                synergy = hero.Synergy;
            }

            if (hero.Discord == null)
            {
                discord = "None";
            }
            else
            {
                discord = hero.Discord;
            }

            String[] strengthsArray = strengths.Split(delimiter);
            String[] weaknessesArray = weaknesses.Split(delimiter);
            String[] countersArray = counters.Split(delimiter);
            String[] counteredbyArray = counteredby.Split(delimiter);
            String[] synergyArray = synergy.Split(delimiter);
            String[] discordArray = discord.Split(delimiter);

            ViewBag.strengthsArray = strengthsArray;
            ViewBag.weaknessesArray = weaknessesArray;
            ViewBag.countersArray = countersArray;
            ViewBag.counteredbyArray = counteredbyArray;
            ViewBag.synergyArray = synergyArray;
            ViewBag.discordArray = discordArray;
            ViewBag.name = hero.HeroName;
            return View(hero);
        }

        // GET: Heroes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Heroes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "HeroCode,HeroName,Category,Image,Strengths,Weaknesses,Counters,Counteredby,Synergy,Discord,Description")] Hero hero)
        {
            if (ModelState.IsValid)
            {
                db.Heroes.Add(hero);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(hero);
        }

        // GET: Heroes/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hero hero = await db.Heroes.FindAsync(id);
            if (hero == null)
            {
                return HttpNotFound();
            }
            return View(hero);
        }

        // POST: Heroes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "HeroCode,HeroName,Category,Image,Strengths,Weaknesses,Counters,Counteredby,Synergy,Discord,Description")] Hero hero)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hero).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(hero);
        }

        // GET: Heroes/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hero hero = await db.Heroes.FindAsync(id);
            if (hero == null)
            {
                return HttpNotFound();
            }
            return View(hero);
        }

        // POST: Heroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            Hero hero = await db.Heroes.FindAsync(id);
            db.Heroes.Remove(hero);
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
