using System.ComponentModel.DataAnnotations;

namespace Dinamo2023.Shared.Entities
{
    public class Service
    {
        private const string MESSAGE_MAX_LENGHT = "El campo {0} no puede tener más de {1} caractéres";
        private const string MESSAGE_FIELD_REQUIRED = "El campo {0} es obligatorio.";

        public int Id { get; set; }

        [Display(Name = "Nombre de quien entrega")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        [MaxLength(50, ErrorMessage = MESSAGE_MAX_LENGHT)]
        public string NameDeliverer { get; set; } = null!;

        [Display(Name = "Direccion de Recogida")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        [MaxLength(100, ErrorMessage = MESSAGE_MAX_LENGHT)]
        public string PickUpAddress { get; set; } = null!;

        [Display(Name = "Indicaciones de Recogida")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        [MaxLength(100, ErrorMessage = MESSAGE_MAX_LENGHT)]
        public string PickUpInstructions { get; set; } = null!;

        [Display(Name = "Telefono de Recogida")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        [MaxLength(15, ErrorMessage = MESSAGE_MAX_LENGHT)]
        public string PickUpPhoneNumber { get; set; } = null!;

        [Display(Name = "Informacion del paquete")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        [MaxLength(100, ErrorMessage = MESSAGE_MAX_LENGHT)]
        public string PackageInformation { get; set; } = null!;

        [Display(Name = "Tipo Paquete")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        public int IdPackegeSize { get; set; }

        [Display(Name = "Nombre de quien recibe")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        [MaxLength(50, ErrorMessage = MESSAGE_MAX_LENGHT)]
        public string NameRecipient { get; set; } = null!;

        [Display(Name = "Direccion de Entrega")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        [MaxLength(100, ErrorMessage = MESSAGE_MAX_LENGHT)]
        public string DeliveryAddress { get; set; } = null!;

        [Display(Name = "Instrucciones de Recogida")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        [MaxLength(100, ErrorMessage = MESSAGE_MAX_LENGHT)]
        public string DeliveryInstructions { get; set; } = null!;

        [Display(Name = "Telefono de Entrega")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        [MaxLength(15, ErrorMessage = MESSAGE_MAX_LENGHT)]
        public string DeliveryPhoneNumber { get; set; } = null!;

        [Display(Name = "Información de la compra")]
        [MaxLength(200, ErrorMessage = MESSAGE_MAX_LENGHT)]
        public string? PurchaseInformation { get; set; } = null!;

        [Display(Name = "Costo del servicio")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        public int CostService { get; set; }

        [Display(Name = "Estado del servicio")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        [MaxLength(15, ErrorMessage = MESSAGE_MAX_LENGHT)]
        public String StatusService { get; set; } = null!;

        [Display(Name = "Plan asociado al cliente asociado para tomar el servicio")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        public int IdPlan { get; set; }

        [Display(Name = "Usuario que solicito el sericio")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        public int IdUser { get; set; }

        [Display(Name = "Mensajero que tomo el sericio")]
        public int? IdCourier { get; set; }

        [Display(Name = "Tipo de servicio")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        public int IdServiceType { get; set; }

        [Display(Name = "Nota Adicional del servicio")]
        [MaxLength(200, ErrorMessage = MESSAGE_MAX_LENGHT)]
        public String? FinalNote { get; set; } = null!;

        [Display(Name = "Fecha de creación del servicio")]
        [Required(ErrorMessage = MESSAGE_FIELD_REQUIRED)]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Fecha de modificación del servicio")]
        public DateTime? ModificationDate { get; set; }

        [Display(Name = "Fecha de entrega y completado del servicio")]
        public DateTime? DeliveryDate { get; set; }
    }
}
