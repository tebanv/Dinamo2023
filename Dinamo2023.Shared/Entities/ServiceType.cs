using System.ComponentModel.DataAnnotations;

namespace Dinamo2023.Shared.Entities
{
    public class ServiceType
    {
        private const string MESSAGE_MAX_LENGHT = "El campo {0} no puede tener más de {1} caractéres";
        private const string MESSAGE_FIELD_REQUIRED = "El campo {0} es obligatorio.";
        public int Id { get; set; }

        [Display(Name = "Tipo de Servicio")]
        [Required(ErrorMessage = MESSAGE_MAX_LENGHT)]
        [MaxLength(30, ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        public string Name { get; set; } = null!;

        [Display(Name = "Comision que se le cobra al que pide el servicio")]
        [Required(ErrorMessage = MESSAGE_MAX_LENGHT)]
        public int Commission { get; set; }

        [Display(Name = "Descripcion del tipo de servcio")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        [MaxLength(50, ErrorMessage = MESSAGE_MAX_LENGHT)]
        public string Description { get; set; } = null!;

    }
}
