using ActividadAsincrona2.Models.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ActividadAsincrona2.Pages.Post
{
    public class DeleteModel(DataBaseContext db) : PageModel
    {
        public ActividadAsincrona2.Models.Post? Post { get; set; } = new Models.Post();
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Post = await db.Posts.FindAsync(id);
            return Post is null ? NotFound() : Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            var t = await db.Posts.FindAsync(id);
            if (t is null)
            {
                return NotFound();
            }
            db.Posts.Remove(t);
            db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
