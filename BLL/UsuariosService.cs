using MacoriStars.DAL;
using MacoriStars.Dtos;
using MacoriStars.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MacoriStars.BLL
{
    public class UsuariosService : IUsuariosService
    {
        private readonly Contexto contexto;
        private readonly SesionDto sesion;
        public UsuariosService(Contexto _contexto, SesionDto dto)
        {
            this.contexto = _contexto;
            this.sesion = dto;
        }

        public void CerrarSesion()
        {
            sesion.SetUsuarioLog(0);
        }

        public async Task<List<Usuarios>> GetListAsync(Expression<Func<Usuarios, bool>> criterio)
        {
            var lista = await contexto.Usuarios.Where(criterio)
                    .AsNoTracking()
                    .ToListAsync();
            return lista;
        }

        public async Task<Usuarios> GetUsuario(int idUsuario)
        {
            return await contexto.Usuarios.FindAsync(idUsuario);
        }

        public string GetNameUserById(int idUsuario)
        {
            return contexto.Usuarios.Where(x => x.IdUsuario == idUsuario).Select(x => x.Nombre).FirstOrDefault();
        }

        public Task<Usuarios> GetUsuarioLogueado()
        {
            int usuarioL = sesion.GetUsuarioLog();
            try
            {
                if (usuarioL != 0)
                {
                    return GetUsuario(usuarioL);
                }
                else
                {
                    return GetUsuario(0);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<Usuarios>> GetUsuarios()
        {
            var usuarios = await contexto.Usuarios
                .AsNoTracking()
                .ToListAsync();
            return usuarios;
        }

        public async Task<Usuarios> Login(string username, string password)
        {
            var user = await contexto.Usuarios
                .Where(x => x.NombreUsuario == username && x.Contrasena == password)
                .AsNoTracking()
                .FirstOrDefaultAsync();
            if(user != null)
            {
                sesion.SetUsuarioLog(user.IdUsuario);
            }
            return user;
        }

        public async Task<bool> RegistrarUsuario(Usuarios usuario)
        {
            bool paso = false;
            try
            {
                await contexto.Usuarios.AddAsync(usuario);
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
