using System.ComponentModel.DataAnnotations;

namespace Dinamo2023.Shared.Entities
{
    public class VehicleType
    {
        public int Id { get; set; }

        [Display(Name = "Tipo de Vehiculo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string VehicleTypeName { get; set; } = null!;

        [Display(Name = "Descripcion del tipo de servcio")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Description { get; set; } = null!;

    }
}
