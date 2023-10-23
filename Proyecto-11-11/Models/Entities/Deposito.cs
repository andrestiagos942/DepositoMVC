using System.ComponentModel.DataAnnotations;

namespace Proyecto_11_11.Models.Entities
{
    public class Deposito
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public String Producto { get; set; }

        [Required]
        public int Stock { get; set; }

    }
}
