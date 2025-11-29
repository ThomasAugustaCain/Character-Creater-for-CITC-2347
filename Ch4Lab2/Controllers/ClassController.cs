using System.Diagnostics;
using System.Numerics;
using LordsOfTheFallenCharacterCreation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CharacterCreater.Controllers
{
    public class ClassController : Controller
    {

        private CharacterContext Context { get; set; }

        // constructor method
        public ClassController(CharacterContext context)
        {
            Context = context;
        }

        // GET: CharacterController
        public IActionResult Index()
        {
            //querying the database to return ALL classes ordered by name
            List<Class> classes =
                Context.Classes
                .OrderBy(m => m.Name)
                .ToList();

            return View(classes);
        }

        // GET: CharacterController/Create
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Edit";

            return View("Edit", new Class());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var clas = Context.Classes.Find(id);

            return View(clas);
        }

        [HttpPost]
        public IActionResult Edit(Class clas)
        {
            if (ModelState.IsValid)
            {
                if (clas.ClassId == 0)
                {
                    Context.Classes.Add(clas);
                }
                else
                {
                    Context.Classes.Update(clas);
                }

                Context.SaveChanges();

                return RedirectToAction("Index", "Player");
            }
            else
            {
                ViewBag.Action = (clas.ClassId == 0) ? "Add" : "Edit";

                return View(clas);
            }
        }

        // GET: ClassController/Delete/5
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var clas = Context.Classes.Find(id);


            return View(clas);
        }

        // POST: ClassController/Delete/5
        [HttpPost]
        public IActionResult Delete(Class clas)
        {
            Context.Classes.Remove(clas);
            Context.SaveChanges();

            return RedirectToAction("Index", "Player");
        }

    }
}
