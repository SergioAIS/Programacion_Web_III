using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ActAsíncrona1Web3.Pages
{
    public class NoticiasModel : PageModel
    {
        private readonly ILogger<NoticiasModel> _logger;

        public NoticiasModel(ILogger<NoticiasModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
