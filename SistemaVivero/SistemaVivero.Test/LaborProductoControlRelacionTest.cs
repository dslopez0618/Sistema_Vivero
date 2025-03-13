using SistemaVivero.Models;

namespace SistemaVivero.Test;

public class LaborProductoControlRelacionTest
{
    [Fact]
    public void Labor_PuedeTenerProductoControlPlagaAsociado()
    {
        var productoPlaga = new ProductoControlPlaga
        {
            RegistroICA = "ICA456",
            Nombre = "PlagaStop",
            FrecuenciaAplicacionDias = 20,
            Valor = 25000,
            PeriodoCarencia = 10
        };

        var labor = new Labor
        {
            Fecha = new DateTime(2025, 3, 15),
            Descripcion = "Aplicacion de producto contra plagas",
            ProductoControl = productoPlaga
        };

        Assert.NotNull(labor.ProductoControl);
        Assert.IsType<ProductoControlPlaga>(labor.ProductoControl);
        Assert.Equal("PlagaStop", labor.ProductoControl.Nombre);
    }
}
