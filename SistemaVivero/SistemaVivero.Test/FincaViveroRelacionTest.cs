using SistemaVivero.Models;

namespace SistemaVivero.Test;

public class FincaViveroRelacionTest
{
    [Fact]
    public void Finca_PuedeTenerMultiplesViveros()
    {
        var finca = new Finca
        {
            NumeroCatastro = "789",
            Municipio = "Marsella"
        };

        var vivero1 = new Vivero
        {
            Codigo = "VIV01",
            TipoCultivo = "Café",
            Finca = finca
        };

        var vivero2 = new Vivero
        {
            Codigo = "VIV02",
            TipoCultivo = "Plátano",
            Finca = finca
        };

        finca.Viveros = new List<Vivero> { vivero1, vivero2 };

        var viveros = finca.Viveros.ToList();

        Assert.Equal(2, viveros.Count);
        Assert.Equal("VIV01", viveros[0].Codigo);
        Assert.Equal("VIV02", viveros[1].Codigo);
    }
}