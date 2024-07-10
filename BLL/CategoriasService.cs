using MacoriStars.DAL;
using MacoriStars.Models;
using Microsoft.EntityFrameworkCore;

namespace MacoriStars.BLL
{
    public class CategoriasService : ICategoriasServices
    {
        private readonly Contexto contexto;

        public CategoriasService(Contexto _contexto)
        {
            this.contexto = _contexto;
        }
        /// <summary>
        /// Permite buscar una tarea mediante id
        /// </summary>
        /// <param name="id">El Id de la entidad que se desea buscar</param>
        public async Task<Categorias> GetCategoria(int idCategoria)
        {
            var categoria = await contexto.Categorias
                .Where(x=> x.IdCategoria == idCategoria)
                .AsNoTracking()
                .FirstOrDefaultAsync();
            return categoria;
        }
        /// <summary>
        /// Permite buscar una tarea mediante id
        /// </summary>
        /// <param name="id">El Id de la entidad que se desea buscar</param>
        public async Task<List<Categorias>> GetCategorias()
        {
            var categorias = await contexto.Categorias.ToListAsync();
            return categorias;
        }
    }
}
