using SistemaVivero.Models;

namespace SistemaVivero.Test;

public class FincaTest
{
    [Fact]
    public void CrearFinca_Valido_DeberiaCrearCorrectamente()
    {
        var finca = new Finca
        {
            NumeroCatastro = "123ABC",
            Municipio = "Pereira",
            ProductorId = 1
        };

        Assert.Equal("123ABC", finca.NumeroCatastro);
        Assert.Equal("Pereira", finca.Municipio);
        Assert.Equal(1, finca.ProductorId);
    }

    [Fact]
    public void CrearFinca_SinNumeroCatastro_DeberiaFallar()
    {
        
        var finca = new Finca
        {
            NumeroCatastro = "",
            Municipio = "Pereira",
            ProductorId = 1
        };

        
        Assert.True(string.IsNullOrWhiteSpace(finca.NumeroCatastro));
    }

    [Fact]
    public void CrearFinca_SinMunicipio_DeberiaFallar()
    {
        
        var finca = new Finca
        {
            NumeroCatastro = "456DEF",
            Municipio = "",
            ProductorId = 1
        };

        
        Assert.True(string.IsNullOrWhiteSpace(finca.Municipio));
    }
}
