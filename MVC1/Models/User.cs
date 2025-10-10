using System.ComponentModel.DataAnnotations;

namespace MVC1.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [StringLength (20)]
        public string Name { get; set; }
        [Required]
        [StringLength (30)]
        public string LastName { get; set; }
        [Required]
        [DataType (DataType.EmailAddress)]
        public string Email { get; set; }
        [StringLength (16, MinimumLength = 8)]
        public string Password { get; set; }
        [DataType (DataType.PhoneNumber)]
        [StringLength (10, MinimumLength =10)]
        public string Phone { get; set; }
    }
}
