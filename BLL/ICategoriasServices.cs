using MacoriStars.Models;

namespace MacoriStars.BLL
{
    public interface ICategoriasServices
    {
        Task<List<Categorias>> GetCategorias();
        Task<Categorias> GetCategoria(int idCategoria);
    }
}
