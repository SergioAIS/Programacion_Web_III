using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MigracionDB.Models.Data;

namespace MigracionDB.Pages.Tag
{
    public class IndexModel(DataBaseContext db) : PageModel
    {
        public List<MigracionDB.Models.Tag> Tages { get; set; } = new List<MigracionDB.Models.Tag>();
        public  async Task OnGetAsync()
        {
            Tages = await db.Tags.AsNoTracking().OrderBy(x => x.Id).ToListAsync();
        }
    }
}
