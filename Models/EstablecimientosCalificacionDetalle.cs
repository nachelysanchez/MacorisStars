using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MacoriStars.Models
{
    public class EstablecimientosCalificacionDetalle
    {
        [Key]
        public int Id { get; set; }
        public int IdEstablecimiento { get; set; }
        [ForeignKey("IdEstablecimiento")]
        public Establecimientos Establecimiento { get; set; }
        public int IdCalificacion { get; set; }
        [ForeignKey("IdCalificacion")]
        public Calificaciones Calificacion { get; set; }
    }
}
