using System.ComponentModel.DataAnnotations;

namespace esercizioUnikey.Core.Model
{
    public class BaseUser
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        public ProfileType Profile { get; set; }
    }
}