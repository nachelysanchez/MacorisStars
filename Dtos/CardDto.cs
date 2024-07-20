namespace MacoriStars.Dtos
{
    public class CardDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
    }

    public class ResenasEstablecimientos
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Comentario { get; set; }
    }
}
