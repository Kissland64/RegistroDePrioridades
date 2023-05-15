using System.ComponentModel.DataAnnotations;

namespace Registrodeprioridades.Modelo
{
    public class Prioridades
    {
        [Key]
        public int PrioridadesId { get; set; }

        [Required(ErrorMessage = "Obligatoriamente tiene que tener una descripcion")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Obligatoriamente tiene que tener los Dias compromiso")]

        public int DiasCompromiso { get; set; }
    }
}