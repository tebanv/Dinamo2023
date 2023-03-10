using System.ComponentModel.DataAnnotations;

namespace Dinamo2023.Shared.Entities
{
    public class ParamSys
    {
        private const string MESSAGE_MAX_LENGHT = "El campo {0} no puede tener más de {1} caractéres";
        private const string MESSAGE_FIELD_REQUIRED = "El campo {0} es obligatorio.";
        public int Id { get; set; }

        [Display(Name = "Id del Parametro Padre")]
        public int? IdParameterFather { get; set; }

        [Display(Name = "Parametro")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        [MaxLength(50, ErrorMessage = MESSAGE_MAX_LENGHT)]
        public string Parameter { get; set; } = null!;

        [Display(Name = "Valor del Parametro")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        [MaxLength(100, ErrorMessage = MESSAGE_MAX_LENGHT)]
        public string ParameterValue { get; set; } = null!;

        [Display(Name = "Descripción del Parametro")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        [MaxLength(100, ErrorMessage = MESSAGE_MAX_LENGHT)]
        public string ParameterDescription { get; set; } = null!;

        [Display(Name = "Abreviación del Parametro")]
        [MaxLength(15, ErrorMessage = MESSAGE_MAX_LENGHT)]
        public string? ParameterAbreviature { get; set; } = null!;

    }
}
