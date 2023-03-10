using System.ComponentModel.DataAnnotations;

namespace Dinamo2023.Shared.Entities
{
    public class VehicleType
    {
        private const string MESSAGE_MAX_LENGHT = "El campo {0} no puede tener más de {1} caractéres";
        private const string MESSAGE_FIELD_REQUIRED = "El campo {0} es obligatorio.";
        public int Id { get; set; }

        [Display(Name = "Tipo de Vehiculo")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        [MaxLength(50, ErrorMessage = MESSAGE_MAX_LENGHT)]
        public string VehicleTypeName { get; set; } = null!;

        [Display(Name = "Descripcion del tipo de servcio")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        [MaxLength(100, ErrorMessage = MESSAGE_MAX_LENGHT)]
        public string Description { get; set; } = null!;

    }
}
