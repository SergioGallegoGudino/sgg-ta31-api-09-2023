using System.ComponentModel.DataAnnotations;

namespace TA31_api_sgallego.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        public String Nombre { get; set; }

        public String Apellido { get; set; }

        public String Direccion { get; set; }

        public int Dni { get; set; }

        public DateTime Fecha { get; set; }

        public ICollection<Video>? Videos { get; set; }
    }

    public class Video
    {
        [Key]
        public int Id { get; set; }

        public String Titulo { get; set; }

        public String Director { get; set; }

        public Cliente Cliente { get; set; }
    }

}
