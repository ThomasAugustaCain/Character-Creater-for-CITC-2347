using System.Diagnostics;
using LordsOfTheFallenCharacterCreation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CharacterCreater.Controllers
{
    public class AncestryController : Controller
    {
        private CharacterContext Context { get; set; }

        // constructor method
        public AncestryController(CharacterContext context)
        {
            Context = context;
        }

        // GET: raceController
        public IActionResult Index()
        {
            //querying the database to return ALL race ordered by name
            List<Class> race =
                Context.Classes
                .OrderBy(m => m.Name)
                .ToList();

            return View(race);
        }

        // GET: RaceController/Create
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Edit";

            return View("Edit", new Ancestry());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var race = Context.Classes.Find(id);

            return View(race);
        }

        [HttpPost]
        public IActionResult Edit(Ancestry race)
        {
            if (ModelState.IsValid)
            {
                if (race.AncestryId == 0)
                {
                    Context.Ancestrys.Add(race);
                }
                else
                {
                    Context.Ancestrys.Update(race);
                }

                Context.SaveChanges();

                return RedirectToAction("Index", "Ancestry");
            }
            else
            {
                ViewBag.Action = (race.AncestryId == 0) ? "Add" : "Edit";

                return View(race);
            }
        }

        // GET: raceController/Delete/5
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var race = Context.Ancestrys.Find(id);


            return View(race);
        }

        // POST: raceController/Delete/5
        [HttpPost]
        public IActionResult Delete(Ancestry race)
        {
            Context.Ancestrys.Remove(race);
            Context.SaveChanges();

            return RedirectToAction("Index", "Ancestry");
        }
    }
}
