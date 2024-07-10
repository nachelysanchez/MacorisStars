using MacoriStars.Models;
using System.Linq.Expressions;

namespace MacoriStars.BLL
{
    public interface IEstablecimientosService
    {
        Task<Establecimientos> GetEstablecimiento(int idEstablecimiento);
        Task<List<Establecimientos>> GetEstablecimientos();
        Task<List<Establecimientos>> GetList(Expression<Func<Establecimientos, bool>> criterio);
    }
}
