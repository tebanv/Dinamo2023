using System.ComponentModel.DataAnnotations;

namespace Dinamo2023.Shared.Entities
{
    public class Service
    {
        public int Id { get; set; }

        [Display(Name = "Nombre de quien entrega")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string NameDeliverer { get; set; } = null!;

        [Display(Name = "Direccion de Recogida")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string PickUpAddress { get; set; } = null!;

        [Display(Name = "Indicaciones de Recogida")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string PickUpInstructions { get; set; } = null!;

        [Display(Name = "Telefono de Recogida")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string PickUpPhoneNumber { get; set; } = null!;

        [Display(Name = "Informacion del paquete")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string PackageInformation { get; set; } = null!;

        [Display(Name = "Tipo Paquete")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public int IdPackegeSize { get; set; }

        [Display(Name = "Nombre de quien recibe")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string NameRecipient { get; set; } = null!;

        [Display(Name = "Direccion de Entrega")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string DeliveryAddress { get; set; } = null!;

        [Display(Name = "Instrucciones de Recogida")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string DeliveryInstructions { get; set; } = null!;

        [Display(Name = "Telefono de Entrega")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string DeliveryPhoneNumber { get; set; } = null!;

        [Display(Name = "Información de la compra")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public string PurchaseInformation { get; set; } = null!;

        [Display(Name = "Costo del servicio")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public int CostService { get; set; }

        [Display(Name = "Estado del servicio")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public String StatusService { get; set; } = null!;

        [Display(Name = "Plan asociado al cliente asociado para tomar el servicio")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public int IdPlan { get; set; }

        [Display(Name = "Usuario que solicito el sericio")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public int IdUser { get; set; }

        [Display(Name = "Mensajero que tomo el sericio")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public int IdCourier { get; set; }

        [Display(Name = "Tipo de servicio")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public int IdServiceType { get; set; }

        [Display(Name = "Nota Adicional del servicio")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public String FinalNote { get; set; } = null!;

        [Display(Name = "Fecha de creación del servicio")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Fecha de modificación del servicio")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public DateTime ModificationDate { get; set; }

        [Display(Name = "Fecha de entrega y completado del servicio")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public DateTime DeliveryDate { get; set; }

    }
}
