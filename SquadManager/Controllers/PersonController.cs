using Microsoft.AspNetCore.Mvc;
using SquadManager.Models;

namespace SquadManager.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(PersonViewModel model = null)
        {
            return View(model ?? new PersonViewModel());
        }
    }
}
