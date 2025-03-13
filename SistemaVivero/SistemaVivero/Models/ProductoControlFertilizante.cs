using System.ComponentModel.DataAnnotations;

namespace SistemaVivero.Models;

public class ProductoControlFertilizante : ProductoControl
{
    [Required]
    public DateTime FechaUltimaAplicacion { get; set; }
}