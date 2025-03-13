using SistemaVivero.Models;

namespace SistemaVivero.Test;

public class ViveroTest
{
    [Fact]
    public void CrearVivero_Valido_DeberiaCrearCorrectamente()
    {
        var vivero = new Vivero
        {
            Codigo = "VIV001",
            TipoCultivo = "Tomate",
            FincaId = 1
        };

        Assert.Equal("VIV001", vivero.Codigo);
        Assert.Equal("Tomate", vivero.TipoCultivo);
        Assert.Equal(1, vivero.FincaId);
    }

    [Fact]
    public void CrearVivero_SinCodigo_DeberiaFallar()
    {
        var vivero = new Vivero
        {
            Codigo = "",
            TipoCultivo = "Tomate",
            FincaId = 1
        };

        Assert.True(string.IsNullOrWhiteSpace(vivero.Codigo));
    }

    [Fact]
    public void CrearVivero_SinTipoCultivo_DeberiaFallar()
    {
        var vivero = new Vivero
        {
            Codigo = "VIV002",
            TipoCultivo = "",
            FincaId = 1
        };

        Assert.True(string.IsNullOrWhiteSpace(vivero.TipoCultivo));
    }
}
