using System.ComponentModel.DataAnnotations;

namespace Dinamo2023.Shared.Entities
{
    public class UserVehicles
    {
        public int Id { get; set; }

        [Display(Name = "Id del Usuario Propietario del Vehiculo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public int IdUser { get; set; }

        [Display(Name = "Id del Vehiculo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string IdVehicle { get; set; } = null!;

    }
}
