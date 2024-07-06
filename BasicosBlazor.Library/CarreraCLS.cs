using System.ComponentModel.DataAnnotations;

namespace BasicosBlazor.Library;

public class CarreraCLS
{
    public int idcarrera { get; set; }

    [Required(ErrorMessage = "El nombre de la carrera es obligatorio")]
    public string nombrecarrera { get; set; }

    [Required(ErrorMessage = "La descripción de la carrera es obligatoria")]
    public string descripcioncarrera { get; set; }
}
