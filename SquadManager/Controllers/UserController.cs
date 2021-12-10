using Microsoft.AspNetCore.Mvc;
using SquadManager.Models;

namespace SquadManager.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Edit(UserViewModel model)
        {
            return View(model ?? new UserViewModel());
        }
    }
}
