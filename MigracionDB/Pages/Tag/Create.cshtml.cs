using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MigracionDB.Models.Data;

namespace MigracionDB.Pages.Tag
{
    public class CreateModel(DataBaseContext db) : PageModel
    {
        [BindProperty]
        public MigracionDB.Models.Tag Tag { get; set; } = new Models.Tag();
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            db.Tags.Add(Tag);
            await db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
