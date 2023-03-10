using System.ComponentModel.DataAnnotations;

namespace Dinamo2023.Shared.Entities
{
    public class Vehicle
    {
        private const string MESSAGE_MAX_LENGHT = "El campo {0} no puede tener más de {1} caractéres";
        private const string MESSAGE_FIELD_REQUIRED = "El campo {0} es obligatorio.";
        public int Id { get; set; }

        [Display(Name = "Kilometraje del Vehiculo")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        public int Mileage { get; set; }

        [Display(Name = "Placa del Vehiculo")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        [MaxLength(7, ErrorMessage = MESSAGE_MAX_LENGHT)]
        public string LicensePlate { get; set; } = null!;

        [Display(Name = "Marca del Vehiculo")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        [MaxLength(50, ErrorMessage = MESSAGE_MAX_LENGHT)]
        public string Brand { get; set; } = null!;

        [Display(Name = "Tipo de Vehiculo")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        public int IdVehicleType { get; set; }

        [Display(Name = "Modelo del Vehiculo")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        public int Model { get; set; }

    }
}
