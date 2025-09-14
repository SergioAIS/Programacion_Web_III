using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MigracionDB.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace MigracionDB.Pages.User
{
    public class EditModel(DataBaseContext db) : PageModel
    {
        [BindProperty]
        public MigracionDB.Models.User? User { get; set; } = new Models.User();
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            User = await db.Users.FindAsync(id);
            return User is null ? NotFound() : Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            db.Attach(User).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
