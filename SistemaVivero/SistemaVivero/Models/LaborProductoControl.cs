using System.ComponentModel.DataAnnotations;

namespace SistemaVivero.Models;

public class LaborProductoControl
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int LaborId { get; set; }

    [Required]
    public int ProductoControlId { get; set; }

    [Required]
    public string TipoProducto { get; set; } = string.Empty;

    // Relaciones de navegación (opcional pero útil para pruebas más adelante)
    public Labor? Labor { get; set; }
    public ProductoControl? ProductoControl { get; set; }
}
