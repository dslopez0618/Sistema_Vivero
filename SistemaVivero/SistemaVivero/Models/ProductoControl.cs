using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaVivero.Models;

public abstract class ProductoControl
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(30)]
    public string RegistroICA { get; set; }

    [Required, MaxLength(100)]
    public string Nombre { get; set; }

    [Required]
    public int FrecuenciaAplicacionDias { get; set; }

    [Required]
    public decimal Valor { get; set; }

    // FK para herencia en Labor
    public int? LaborId { get; set; }

    [ForeignKey("LaborId")]
    public Labor Labor { get; set; }
}
