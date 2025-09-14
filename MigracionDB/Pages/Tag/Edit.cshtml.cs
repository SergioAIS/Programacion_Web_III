using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MigracionDB.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace MigracionDB.Pages.Tag
{
    public class EditModel(DataBaseContext db) : PageModel
    {
        [BindProperty]
        public MigracionDB.Models.Tag? Tag { get; set; } = new Models.Tag();
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Tag = await db.Tags.FindAsync(id);
            return Tag is null ? NotFound() : Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            db.Attach(Tag).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
