using MacoriStars.Models;
using System.Linq.Expressions;

namespace MacoriStars.BLL
{
    public interface IUsuariosService
    {
        Task<Usuarios> Login(string username, string password);
        Task<Usuarios> GetUsuario(int idUsuario);
        public Task<Usuarios> GetUsuarioLogueado();
        public void CerrarSesion();
        public Task<List<Usuarios>> GetUsuarios();
        public Task<List<Usuarios>> GetListAsync(Expression<Func<Usuarios, bool>> criterio);
        public Task<bool> ModificarUsuario(Usuarios usuario);
        public Task<bool> RegistrarUsuario(Usuarios usuario);
    }
}
