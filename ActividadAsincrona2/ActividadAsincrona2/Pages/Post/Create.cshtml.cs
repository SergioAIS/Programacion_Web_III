using ActividadAsincrona2.Models.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ActividadAsincrona2.Pages.Post
{
    public class CreateModel(DataBaseContext db) : PageModel
    {
        [BindProperty]
        public ActividadAsincrona2.Models.Post Post { get; set; } = new Models.Post();
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            db.Posts.Add(Post);
            await db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
