
using System.ComponentModel.DataAnnotations;

namespace TA31_3_sgallego.Model
{
    public class Cientifico
    {
        [Key]
        public String Dni { get; set; }

        public String NomApels { get; set; }

        public ICollection<CientificoProyecto> CientificoProyectos { get; set; }
    }

    public class Proyecto
    {
        [Key]
        public String Id { get; set; }

        public String Nombre { get; set; }

        public int Horas { get; set; }
        public ICollection<CientificoProyecto> CientificoProyectos { get; set; }

    }

    public class CientificoProyecto
    {
        [Key]
        public String CientificoDni { get; set; }
        [Key]
        public String ProyectoId { get; set; }

        public Cientifico Cientifico { get; set; }
        public Proyecto Proyecto { get; set; }
    }
}
