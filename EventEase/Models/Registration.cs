using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Registration
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Correo inválido")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Selecciona un evento")]
        public int EventId { get; set; }
    }
}
