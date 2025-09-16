using Microsoft.AspNetCore.Mvc;
using MVC1.Models;
using MVC1.Models.Data;

namespace MVC1.Controllers
{
    public class UserController : Controller
    {
        private readonly HelpDeskDBContext _db;
        public UserController(HelpDeskDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
                _db.Add(user);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(user);
        }
    }
}
