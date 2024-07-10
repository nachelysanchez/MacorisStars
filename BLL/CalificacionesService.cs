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
    }
}
