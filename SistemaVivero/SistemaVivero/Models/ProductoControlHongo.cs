using System.ComponentModel.DataAnnotations;

namespace SistemaVivero.Models;

public class ProductoControlHongo : ProductoControl
{
    [Required]
    public int PeriodoCarencia { get; set; }

    [Required, MaxLength(100)]
    public string NombreHongo { get; set; }
}