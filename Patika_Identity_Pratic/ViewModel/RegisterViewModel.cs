using System.ComponentModel.DataAnnotations;

namespace Patika_Identity_Pratic.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
