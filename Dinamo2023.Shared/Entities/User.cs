using System.ComponentModel.DataAnnotations;

namespace Dinamo2023.Shared.Entities
{
    public class User
    {
        private const string MESSAGE_MAX_LENGHT = "El campo {0} no puede tener más de {1} caractéres";
        private const string MESSAGE_FIELD_REQUIRED = "El campo {0} es obligatorio.";
        public int Id { get; set; }

        [Display(Name = "Nombre Completo")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        [MaxLength(100, ErrorMessage = MESSAGE_MAX_LENGHT)]
        public string FullName { get; set; } = null!;

        [Display(Name = "Tipo de Documento")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        [MaxLength(20, ErrorMessage = MESSAGE_MAX_LENGHT)]
        public string DocumentType { get; set; } = null!;

        [Display(Name = "Numero de Documento")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        [MaxLength(20, ErrorMessage = MESSAGE_MAX_LENGHT)]
        public string DocumentNumber { get; set; } = null!;

        [Display(Name = "Ciudad")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        [MaxLength(50, ErrorMessage = MESSAGE_MAX_LENGHT)]
        public string City { get; set; } = null!;

        [Display(Name = "Telefono de contacto")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        [MaxLength(15, ErrorMessage = MESSAGE_MAX_LENGHT)]
        public string PhoneNumber { get; set; } = null!;

        [Display(Name = "Rol Asociado")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        public int IdUserType { get; set; } 


    }
}
