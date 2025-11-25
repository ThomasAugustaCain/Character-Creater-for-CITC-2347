using System.Diagnostics;
using LordsOfTheFallenCharacterCreation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ch4Lab2.Controllers
{
    public class HomeController : Controller
    {
        //this property is used to communicate with the database
        private CharacterContext Context {  get; set; }

        public HomeController(CharacterContext context)
        {
            Context = context;
        }//end method

        public IActionResult Index()
        {
            List<Character> characters = Context.Characters
                .Include(m => m.Class )
                .Include(m => m.Ancestry)
                .OrderBy(c => c.LastName)
                .ToList();
            return View(characters);
        }//end method
    }//end class
}//end namespace 
