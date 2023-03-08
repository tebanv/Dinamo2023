using System.ComponentModel.DataAnnotations;

namespace Dinamo2023.Shared.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }

        [Display(Name = "Kilometraje del Vehiculo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public int Mileage { get; set; }

        [Display(Name = "Placa del Vehiculo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string LicensePlate { get; set; } = null!;

        [Display(Name = "Marca del Vehiculo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Brand { get; set; } = null!;

        [Display(Name = "Tipo de Vehiculo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public int IdVehicleType { get; set; }

        [Display(Name = "Modelo del Vehiculo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public int Model { get; set; }

    }
}
