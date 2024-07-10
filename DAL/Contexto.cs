using MacoriStars.Models;
using Microsoft.EntityFrameworkCore;

namespace MacoriStars.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Resenas> Resenas { get; set; }
        public DbSet<Calificaciones> Calificaciones { get; set; }
        public DbSet<Establecimientos> Establecimientos { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    }
}
