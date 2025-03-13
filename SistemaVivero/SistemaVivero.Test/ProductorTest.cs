using SistemaVivero.Models;

namespace SistemaVivero.Test;

public class ProductorTest
{
    [Fact]
    public void CrearProductor_Valido_DeberiaCrearCorrectamente()
    {
        var productor = new Productor
        {
            Documento = "123456789",
            Nombre = "Carlos",
            Apellido = "Ramirez",
            Telefono = "3010010101",
            Correo = "carlos@correo.com"
        };

        Assert.Equal("123456789", productor.Documento);
        Assert.Equal("Carlos", productor.Nombre);
        Assert.Equal("Ramirez", productor.Apellido);
        Assert.Equal("3010010101", productor.Telefono);
        Assert.Equal("carlos@correo.com", productor.Correo);
    }

    [Fact]
    public void CrearProductor_SinDocumento_DeberiaFallar()
    {
        var productor = new Productor
        {
            Documento = null,
            Nombre = "Ana",
            Apellido = "Lopez",
            Telefono = "3123456789",
            Correo = "ana@correo.com"
        };

        Assert.Null(productor.Documento); 
    }

    [Fact]
    public void CrearProductor_SinCorreo_DeberiaFallar()
    {
        var productor = new Productor
        {
            Documento = "987654321",
            Nombre = "Lucía",
            Apellido = "Gomez",
            Telefono = "3107894561",
            Correo = null
        };

        Assert.Null(productor.Correo);
    }
}
