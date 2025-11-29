using System.Diagnostics;
using LordsOfTheFallenCharacterCreation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CharacterCreater.Controllers
{
    public class CharacterController : Controller
    {
        //this property is used to communicate with the database
        private CharacterContext Context { get; set; }

        public CharacterController(CharacterContext context)
        {
            Context = context;
        }//end method

        public IActionResult Details(int id)
        {
            var character = Context.Characters
                .Include(m => m.Class)
                .Include(m => m.Ancestry)
                .FirstOrDefault(m => m.CharacterId == id);

            return View(character);
        }//end method

        // GET: CharacterController/Create
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Classes = Context.Classes.OrderBy(g => g.Name).ToList();
            ViewBag.Ancestrys = Context.Ancestrys.OrderBy(g => g.AncestryId).ToList();

            return View(new Character());
        }
        [HttpPost]
        public IActionResult Add(Character character)
        {
            if (ModelState.IsValid)
            {

                Context.Characters.Update(character);

                Context.SaveChanges();

                return RedirectToAction("Details", "Character", new { id = character.CharacterId });

            }
            else
            {
                ViewBag.Classes = Context.Classes.OrderBy(g => g.Name).ToList();
                ViewBag.Ancestrys = Context.Ancestrys.OrderBy(g => g.AncestryId).ToList();
                return View(character);

            }
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Classes = Context.Classes.OrderBy(g => g.Name).ToList();
            ViewBag.Ancestrys = Context.Ancestrys.OrderBy(g => g.AncestryId).ToList();
            var character = Context.Characters
                .Include(m => m.Class)
                .Include(m => m.Ancestry)
                .FirstOrDefault(m => m.CharacterId == id);

            return View(character);
        }

        [HttpPost]
        public IActionResult Edit(Character character)
        {
            if (ModelState.IsValid)
            {
                
                Context.Characters.Update(character);

                Context.SaveChanges();

                return RedirectToAction("Details", "Character", new { id = character.CharacterId });

            }
            else
            {
                ViewBag.Classes = Context.Classes.OrderBy(g => g.Name).ToList();
                ViewBag.Ancestrys = Context.Ancestrys.OrderBy(g => g.AncestryId).ToList();
                return View(character);
 
            }
        }

        // GET: CharacterController/Delete/5
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var character = Context.Characters.Find(id);


            return View(character);
        }

        // POST: CharacterController/Delete/5
        [HttpPost]
        public IActionResult Delete(Character character)
        {
            Context.Characters.Remove(character);
            Context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}
