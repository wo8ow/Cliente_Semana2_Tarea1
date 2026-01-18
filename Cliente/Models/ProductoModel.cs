namespace Cliente.Models
{
    using System.ComponentModel.DataAnnotations;
    public class ProductoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string Nombre { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public double Precio { get; set; }
        public int ClienteModelId { get; set; }
        public ClienteModel ClienteModel { get; set; }
    }
}
