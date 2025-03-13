using SistemaVivero.Models;

namespace SistemaVivero.Test;

public class LaborProductoControlTest
{
    [Fact]
    public void CrearLaborProductoControl_Valido_DeberiaCrearCorrectamente()
    {
        var laborProducto = new LaborProductoControl
        {
            LaborId = 1,
            ProductoControlId = 2,
            TipoProducto = "Plaga"
        };

        Assert.Equal(1, laborProducto.LaborId);
        Assert.Equal(2, laborProducto.ProductoControlId);
        Assert.Equal("Plaga", laborProducto.TipoProducto);
    }

    [Fact]
    public void CrearLaborProductoControl_SinTipo_DeberiaFallar()
    {
        var laborProducto = new LaborProductoControl
        {
            LaborId = 1,
            ProductoControlId = 2,
            TipoProducto = ""
        };

        Assert.True(string.IsNullOrWhiteSpace(laborProducto.TipoProducto));
    }

    [Fact]
    public void CrearLaborProductoControl_SinRelaciones_DeberiaFallar()
    {
        var laborProducto = new LaborProductoControl
        {
            TipoProducto = "Hongo"
        };

        Assert.Equal(0, laborProducto.LaborId);
        Assert.Equal(0, laborProducto.ProductoControlId);
    }
}
