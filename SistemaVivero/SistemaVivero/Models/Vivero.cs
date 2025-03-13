using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaVivero.Models;

public class Vivero
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(30)]
    public string Codigo { get; set; }

    [Required, MaxLength(50)]
    public string TipoCultivo { get; set; }

    [Required]
    public int FincaId { get; set; }

    [ForeignKey("FincaId")]
    public Finca Finca { get; set; }

    public ICollection<Labor> Labores { get; set; }
}