using System.ComponentModel.DataAnnotations;
using System.Data;

namespace MVC2.Models
{
    public class User
    {
        public int Id { get; set; }
        //[Required(ErrorMessage = "Debe colocar el mensaje")]
        [Required]
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

        //public ICollection<Role> Roles { get; set; } = new List<Role>();

        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
