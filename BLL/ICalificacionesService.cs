using MacoriStars.Models;
using System.Linq.Expressions;

namespace MacoriStars.BLL
{
    public interface ICalificacionesService
    {
        Task<bool> Guardar(Calificaciones calificacion);
        public Task<List<Calificaciones>> GetCalificaciones();
        public Task<Calificaciones> GetCalificacion(int id);
        public Task<List<Calificaciones>> GetListAsync(Expression<Func<Calificaciones, bool>> criterio);
    }
}
