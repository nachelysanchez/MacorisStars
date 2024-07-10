using MacoriStars.DAL;
using MacoriStars.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MacoriStars.BLL
{
    public class ResenasService : IResenasService
    {
        private readonly Contexto contexto;

        public ResenasService(Contexto _contexto)
        {
            this.contexto = _contexto;
        }
        public async Task<List<Resenas>> GetListAsync(Expression<Func<Resenas, bool>> criterio)
        {
            var lista = await contexto.Resenas.Where(criterio).AsNoTracking().ToListAsync();
            return lista;
        }

        public async Task<Resenas> GetResena(int id)
        {
            var resena = await contexto.Resenas.Where(x => x.IdResena == id).FirstOrDefaultAsync();
            return resena;
        }

        public async Task<List<Resenas>> GetResenas()
        {
            var lista = await contexto.Resenas.ToListAsync();
            return lista;
        }

        public async Task<bool> Guardar(Resenas resena)
        {
            bool paso = false;
            try
            {
                resena.Establecimiento = null;
                await contexto.Resenas.AddAsync(resena);
                paso = await contexto.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }
    }
}
