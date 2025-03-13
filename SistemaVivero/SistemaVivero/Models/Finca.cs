using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaVivero.Models;

public class Finca
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(30)]
    public string NumeroCatastro { get; set; }

    [Required]
    [MaxLength(50)]
    public string Municipio { get; set; }

    // FK: Id de Productor
    [Required]
    public int ProductorId { get; set; }

    [ForeignKey("ProductorId")]
    public Productor Productor { get; set; }


    // RELACION: Una Finca tiene varios Viveros
    public ICollection<Vivero> Viveros { get; set; }
}