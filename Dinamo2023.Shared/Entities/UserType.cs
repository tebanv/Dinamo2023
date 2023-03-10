using System.ComponentModel.DataAnnotations;

namespace Dinamo2023.Shared.Entities
{
    public class UserType
    {
        private const string MESSAGE_MAX_LENGHT = "El campo {0} no puede tener más de {1} caractéres";
        private const string MESSAGE_FIELD_REQUIRED = "El campo {0} es obligatorio.";
        public int Id { get; set; }

        [Display(Name = "Nombres de Rol")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        [MaxLength(20, ErrorMessage = MESSAGE_MAX_LENGHT)]
        public string RoleName { get; set; } = null!;

        [Display(Name = "Permisos")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        [MaxLength(100, ErrorMessage = MESSAGE_MAX_LENGHT)]
        public string Permissions { get; set; } = null!;

    }
}
