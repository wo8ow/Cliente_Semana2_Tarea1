namespace Cliente.Models
{
    using System.ComponentModel.DataAnnotations;

    using System.Diagnostics.CodeAnalysis;

    public class ClienteModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public int Edad { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string Ciudad { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        [MaxLength(10, ErrorMessage = "La cedula debe tener 10 digitos")]
        [Key]
        public string cedula { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        [DataType(DataType.EmailAddress, ErrorMessage = "No tiene el formato de correo electronico")]
        public string Email { get; set; }
     }
}
