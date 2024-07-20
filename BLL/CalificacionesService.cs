using MacoriStars.DAL;
using MacoriStars.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MacoriStars.BLL
{
    public class CalificacionesService : ICalificacionesService
    {
        private readonly Contexto contexto;

        public CalificacionesService(Contexto _contexto)
        {
            this.contexto = _contexto;
        }
        public async Task<Calificaciones> GetCalificacion(int id)
        {
            var calificacion = await contexto.Calificaciones.Where(x => x.IdCalificacion == id)
                .AsNoTracking().FirstOrDefaultAsync();
            return calificacion;
        }

        public async Task<List<Calificaciones>> GetCalificaciones()
        {
            var calificacion = await contexto.Calificaciones.AsNoTracking().ToListAsync();
            return calificacion;
        }

        public async Task<List<Calificaciones>> GetListAsync(Expression<Func<Calificaciones, bool>> criterio)
        {
            var calificacion = await contexto.Calificaciones.Where(criterio)
                .ToListAsync();
            return calificacion;
        }

        public async Task<bool> Guardar(Calificaciones calificacion)
        {
            bool paso = false;
            try
            {
                calificacion.Establecimiento = null;
                await contexto.Calificaciones.AddAsync(calificacion);
                paso = await contexto.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public async Task<decimal> Calculo(int idEstablecimiento)
        {
            List<Calificaciones> lista = new();
            decimal valor = 0;
            try
            {
                lista = await contexto.Calificaciones.Where(x => x.IdEstablecimiento == idEstablecimiento).AsNoTracking().ToListAsync();
                if (lista.Count > 0)
                {

                    foreach (var item in lista)
                    {

                        valor += item.Valoracion;
                    }
                    valor /= lista.Count;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return valor;
        }
    }
}
