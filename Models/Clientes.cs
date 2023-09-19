using System.ComponentModel.DataAnnotations;

namespace PizzaPlaceApp.Models
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor proporcione su nombre")]
        [StringLength(30, ErrorMessage = "No puedes exceder los 30 caracteres")]
        public string Nombre { get; set; } = default!;

        [Required(ErrorMessage = "Por Favor proporcione su Calle con el Numero de Casa")]
        public string Calle { get; set; } = default!;

        [Required(ErrorMessage = "Por Favor Proporcione una ciudad")]
        public string Ciudad { get; set; } = default!;
    }
}
