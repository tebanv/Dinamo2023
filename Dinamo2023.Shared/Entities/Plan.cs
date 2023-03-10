using System.ComponentModel.DataAnnotations;

namespace Dinamo2023.Shared.Entities
{
    public class Plan
    {
        private const string MESSAGE_MAX_LENGHT = "El campo {0} no puede tener más de {1} caractéres";
        private const string MESSAGE_FIELD_REQUIRED = "El campo {0} es obligatorio.";
        public int Id { get; set; }

        [Display(Name = "Nombre del Plan")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        [MaxLength(100, ErrorMessage = MESSAGE_MAX_LENGHT)]
        public string Name { get; set; } = null!;

        [Display(Name = "Porcentaje de Comision")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        public int Commission { get; set; }

    }
}
