using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MigracionDB.Models.Data;

namespace MigracionDB.Pages.User
{
    public class IndexModel(DataBaseContext db) : PageModel
    {
        public List<MigracionDB.Models.User> Useres { get; set; } = new List<MigracionDB.Models.User>();
        public  async Task OnGetAsync()
        {
            Useres = await db.Users.AsNoTracking().OrderBy(x => x.Id).ToListAsync();
        }
    }
}
