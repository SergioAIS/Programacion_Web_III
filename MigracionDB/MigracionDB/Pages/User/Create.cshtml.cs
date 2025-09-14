using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MigracionDB.Models.Data;

namespace MigracionDB.Pages.User
{
    public class CreateModel(DataBaseContext db) : PageModel
    {
        [BindProperty]
        public MigracionDB.Models.User User { get; set; } = new Models.User();
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            db.Users.Add(User);
            await db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
