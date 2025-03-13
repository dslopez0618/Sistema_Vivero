using System.ComponentModel.DataAnnotations;

namespace SistemaVivero.Models;

public class Productor
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(20)]
    public string Documento { get; set; }

    [Required]
    [MaxLength(50)]
    public string Nombre { get; set; }

    [Required]
    [MaxLength(50)]
    public string Apellido { get; set; }

    [Required]
    [MaxLength(15)]
    public string Telefono { get; set; }

    [Required]
    [EmailAddress]
    [MaxLength(100)]
    public string Correo { get; set; }



    // RELACION: Un Productor tiene varias Fincas
    public ICollection<Finca> Fincas { get; set; }
}
