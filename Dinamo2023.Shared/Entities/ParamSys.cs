using System.ComponentModel.DataAnnotations;

namespace Dinamo2023.Shared.Entities
{
    public class ParamSys
    {
        public int Id { get; set; }

        [Display(Name = "Id del Parametro Padre")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public int IdParameterFather { get; set; }

        [Display(Name = "Parametro")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string Parameter { get; set; } = null!;

        [Display(Name = "Valor del Parametro")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string ParameterValue { get; set; } = null!;

        [Display(Name = "Descripción del Parametro")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string ParameterDescription { get; set; } = null!;

        [Display(Name = "Abreviación del Parametro")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string ParameterAbreviature { get; set; } = null!;

    }
}
