using System.ComponentModel.DataAnnotations;


namespace Proyecto_11_11.Models.Entities
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        public double PrecioUnitario { get; set; }
        
        public double? PrecioMayorista{ get; set; }
    }
}
