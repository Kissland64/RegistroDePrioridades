using System.ComponentModel.DataAnnotations;

namespace Registrodeprioridades.Modelo
{
    public class Prioridades
    {
        [Key]
        public int PrioridadesId { get; set; }

        [Required(ErrorMessage = "La descripcion es un campo necesario")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Los DiasCompromiso son necesarios")]

        public int DiasCompromiso { get; set; }
    }
}