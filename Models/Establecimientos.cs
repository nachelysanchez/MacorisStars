using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MacoriStars.Models
{
    public class Establecimientos
    {
        [Key]
        public int IdEstablecimiento { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public byte[] Imagen { get; set; }
        public int IdCategoria { get; set; }
        [ForeignKey("IdCategoria")]
        public virtual Categorias Categoria { get; set; }
    }
}
