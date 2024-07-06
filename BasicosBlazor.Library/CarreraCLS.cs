using System.ComponentModel.DataAnnotations;

namespace BasicosBlazor.Library;

public class CarreraCLS
{
    public int idcarrera { get; set; }

    [Required(ErrorMessage = "El nombre de la carrera es obligatorio")]
    [MaxLength(100, ErrorMessage = "La longitud máxima del nombre de la carrera es 100")]
    [MinLength(3, ErrorMessage = "La longitud mínima del nombre de la carrera es 3")]
    public string nombrecarrera { get; set; }

    [Required(ErrorMessage = "La descripción de la carrera es obligatoria")]
    [MaxLength(200, ErrorMessage = "La longitud máxima de la descripción de la carrera es 200")]
    [MinLength(3, ErrorMessage = "La longitud mínima de la descripción de la carrera es 3")]
    public string descripcioncarrera { get; set; }
}
