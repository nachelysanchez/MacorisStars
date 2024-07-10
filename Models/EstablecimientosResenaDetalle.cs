using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MacoriStars.Models
{
    public class EstablecimientosResenaDetalle
    {
        [Key]
        public int Id { get; set; }
        public int IdEstablecimiento { get; set; }
        [ForeignKey("IdEstablecimiento")]
        public Establecimientos Establecimiento { get; set; }
        public int IdResena { get; set; }
        [ForeignKey("IdResena")]
        public Resenas Resena { get; set; }
    }
}
