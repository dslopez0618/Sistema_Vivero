using SistemaVivero.Models;

namespace SistemaVivero.Test;

public class ProductorFincaRelacionTest
{
    [Fact]
    public void Productor_PuedeTenerMultiplesFincas()
    {
        var productor = new Productor
        {
            Documento = "12345",
            Nombre = "Carlos",
            Apellido = "Lopez",
            Telefono = "3001234567",
            Correo = "carlos@correo.com"
        };

        var finca1 = new Finca
        {
            NumeroCatastro = "001",
            Municipio = "Pereira",
            Productor = productor
        };

        var finca2 = new Finca
        {
            NumeroCatastro = "002",
            Municipio = "Dosquebradas",
            Productor = productor
        };

        productor.Fincas = new List<Finca> { finca1, finca2 };

        var fincas = productor.Fincas.ToList(); // ✔ Convertimos a lista para usar [0] y [1]

        Assert.Equal(2, fincas.Count);
        Assert.Equal("001", fincas[0].NumeroCatastro);
        Assert.Equal("002", fincas[1].NumeroCatastro);
    }
}
