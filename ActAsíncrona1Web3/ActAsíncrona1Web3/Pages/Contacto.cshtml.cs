using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ActAsíncrona1Web3.Pages
{
    public class ContactoModel : PageModel
    {
        [BindProperty]
        public string Nombre { get; set; } = string.Empty;
        
        [BindProperty]
        public string Email { get; set; } = string.Empty;
        
        [BindProperty]
        public string Asunto { get; set; } = string.Empty;
        
        [BindProperty]
        public string Mensaje { get; set; } = string.Empty;
        
        public string? MensajeConfirmacion { get; set; }
        
        public void OnGet()
        {
            // Página de carga inicial
        }
        
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            // Aquí normalmente enviarías el email o guardarías en base de datos
            // Por ahora solo mostramos un mensaje de confirmación
            
            MensajeConfirmacion = $"Gracias {Nombre}, tu mensaje ha sido recibido. Te contactaremos pronto.";
            
            // Limpiar el formulario
            Nombre = string.Empty;
            Email = string.Empty;
            Asunto = string.Empty;
            Mensaje = string.Empty;
            
            return Page();
        }
    }
}
