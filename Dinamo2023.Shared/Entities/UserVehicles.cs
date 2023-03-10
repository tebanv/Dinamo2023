using System.ComponentModel.DataAnnotations;

namespace Dinamo2023.Shared.Entities
{
    public class UserVehicles
    {
        private const string MESSAGE_FIELD_REQUIRED = "El campo {0} es obligatorio.";
        public int Id { get; set; }

        [Display(Name = "Id del Usuario Propietario del Vehiculo")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        public int IdUser { get; set; }

        [Display(Name = "Id del Vehiculo")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        public int IdVehicle { get; set; }

    }
}
