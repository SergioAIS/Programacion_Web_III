using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MigracionDB.Models.Data;

namespace MigracionDB.Pages.Tag
{
    public class DeleteModel(DataBaseContext db) : PageModel
    {
        public MigracionDB.Models.Tag? Tag { get; set; } = new Models.Tag();
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Tag = await db.Tags.FindAsync(id);
            return Tag is null ? NotFound() : Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            var t = await db.Tags.FindAsync(id);
            if (t is null)
            {
                return NotFound();
            }
            db.Tags.Remove(t);
            db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
