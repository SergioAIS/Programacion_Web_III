using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebRazor1.Pages
{
    public class aboutModel : PageModel
    {
        public string NombrePagina;
        public void OnGet()
        {
            NombrePagina = "Mi aplicación";
        }
        public void OnPost()
        {

        }
    }
}
