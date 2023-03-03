using Microsoft.AspNetCore.Mvc;
using DeepMVCApp.Models;

namespace DeepMVCApp.Controllers
{
    public class UserController : Controller
    {
        UsersContext uc = new();
        public IActionResult DeepView()
        {
            return View(uc.DeepTables.ToList());
        }
    }
}
