using ActividadAsincrona2.Models.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ActividadAsincrona2.Pages.Post
{
    public class IndexModel(DataBaseContext db) : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string? SearchName { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? SearchAuthor { get; set; }

        public List<ActividadAsincrona2.Models.Post> Posts { get; set; } = new();

        public async Task OnGetAsync()
        {
            var query = db.Posts.AsNoTracking();

            if (!string.IsNullOrWhiteSpace(SearchName))
                query = query.Where(x => x.Name.Contains(SearchName));

            if (!string.IsNullOrWhiteSpace(SearchAuthor))
                query = query.Where(x => x.Author.Contains(SearchAuthor));

            Posts = await query
            .OrderByDescending(x => x.CreationDate)
            .ToListAsync();
        }
    }
}
