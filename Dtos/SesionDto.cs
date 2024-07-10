namespace MacoriStars.Dtos
{
    public class SesionDto
    {
        public static int IdUsuarioLogueado { get; set; }
        public void SetUsuarioLog(int idUsuario)
        {
            IdUsuarioLogueado = idUsuario;
        }

        public int GetUsuarioLog()
        {
            return IdUsuarioLogueado;
        }
    }
}
