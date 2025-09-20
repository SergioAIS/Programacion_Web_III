using ActividadAsincrona2.Models.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ActividadAsincrona2.Pages.Post
{
    public class EditModel(DataBaseContext db) : PageModel
    {
        [BindProperty]
        public ActividadAsincrona2.Models.Post? Post { get; set; } = new Models.Post();
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Post = await db.Posts.FindAsync(id);
            return Post is null ? NotFound() : Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            db.Attach(Post).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
