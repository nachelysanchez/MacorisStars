using MacoriStars.DAL;
using MacoriStars.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MacoriStars.BLL
{
    public class EstablecimientosService : IEstablecimientosService
    {
        private readonly Contexto contexto;

        public EstablecimientosService(Contexto _contexto)
        {
            this.contexto = _contexto;
        }
        public async Task<Establecimientos> GetEstablecimiento(int idEstablecimiento)
        {
            try
            {
                var establecimiento = await contexto.Establecimientos
                    .Where(x => x.IdEstablecimiento == idEstablecimiento)
                    .AsNoTracking()
                    .FirstOrDefaultAsync();
                return establecimiento;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<Establecimientos>> GetEstablecimientos()
        {
            var establecimientos = await contexto
                .Establecimientos
                .ToListAsync();
            return establecimientos;
        }

        public async Task<List<Establecimientos>> GetList(Expression<Func<Establecimientos, bool>> criterio)
        {
            var lista = await contexto.Establecimientos.Where(criterio).ToListAsync();
            return lista;
        }
    }
}
