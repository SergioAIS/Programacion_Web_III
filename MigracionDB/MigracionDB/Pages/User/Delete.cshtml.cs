using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MigracionDB.Models.Data;

namespace MigracionDB.Pages.User
{
    public class DeleteModel(DataBaseContext db) : PageModel
    {
        public MigracionDB.Models.User? User { get; set; } = new Models.User();
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            User = await db.Users.FindAsync(id);
            return User is null ? NotFound() : Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            var t = await db.Users.FindAsync(id);
            if (t is null)
            {
                return NotFound();
            }
            db.Users.Remove(t);
            db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
