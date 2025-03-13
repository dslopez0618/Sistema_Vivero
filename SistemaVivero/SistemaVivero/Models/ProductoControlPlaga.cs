using System.ComponentModel.DataAnnotations;

namespace SistemaVivero.Models;

public class ProductoControlPlaga : ProductoControl
{
    [Required]
    public int PeriodoCarencia { get; set; }
}