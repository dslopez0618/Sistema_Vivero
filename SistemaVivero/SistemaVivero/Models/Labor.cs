using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaVivero.Models;

public class Labor
{
    [Key]
    public int Id { get; set; }

    [Required]
    public DateTime Fecha { get; set; }

    [Required, MaxLength(200)]
    public string Descripcion { get; set; }

    [Required]
    public int ViveroId { get; set; }

    [ForeignKey("ViveroId")]
    public Vivero Vivero { get; set; }

    public int ProductoControlId { get; set; }

    [ForeignKey("ProductoControlId")]
    public ProductoControl ProductoControl { get; set; }
}