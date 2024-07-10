using MacoriStars.Models;
using System.Linq.Expressions;

namespace MacoriStars.BLL
{
    public interface IResenasService
    {
        Task<bool> Guardar(Resenas resena);
        public Task<List<Resenas>> GetResenas();
        public Task<Resenas> GetResena(int id);
        public Task<List<Resenas>> GetListAsync(Expression<Func<Resenas, bool>> criterio);
    }
}
