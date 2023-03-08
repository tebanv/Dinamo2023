using System.ComponentModel.DataAnnotations;

namespace Dinamo2023.Shared.Entities
{
    public class UserType
    {
        public int Id { get; set; }

        [Display(Name = "Nombres de Rol")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string RoleName { get; set; } = null!;

        [Display(Name = "Permisos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Permissions { get; set; } = null!;

    }
}
