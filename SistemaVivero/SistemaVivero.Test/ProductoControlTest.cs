using SistemaVivero.Models;

namespace SistemaVivero.Test;

public class ProductoControlTest
{
    [Fact]
    public void CrearProductoControlHongo_Valido_DeberiaCrearCorrectamente()
    {
        var producto = new ProductoControlHongo
        {
            RegistroICA = "ICA12345",
            Nombre = "FungicidaX",
            FrecuenciaAplicacionDias = 15,
            Valor = 20000,
            PeriodoCarencia = 10,
            NombreHongo = "Mildiu"
        };

        Assert.Equal("ICA12345", producto.RegistroICA);
        Assert.Equal("FungicidaX", producto.Nombre);
        Assert.Equal(15, producto.FrecuenciaAplicacionDias);
        Assert.Equal(20000, producto.Valor);
        Assert.Equal(10, producto.PeriodoCarencia);
        Assert.Equal("Mildiu", producto.NombreHongo);
    }

    [Fact]
    public void CrearProductoControlPlaga_Valido_DeberiaCrearCorrectamente()
    {
        var producto = new ProductoControlPlaga
        {
            RegistroICA = "ICA54321",
            Nombre = "PlaguicidaY",
            FrecuenciaAplicacionDias = 30,
            Valor = 18000,
            PeriodoCarencia = 15
        };

        Assert.Equal("ICA54321", producto.RegistroICA);
        Assert.Equal("PlaguicidaY", producto.Nombre);
        Assert.Equal(30, producto.FrecuenciaAplicacionDias);
        Assert.Equal(18000, producto.Valor);
        Assert.Equal(15, producto.PeriodoCarencia);
    }

    [Fact]
    public void CrearProductoControlFertilizante_Valido_DeberiaCrearCorrectamente()
    {
        var producto = new ProductoControlFertilizante
        {
            RegistroICA = "ICA78901",
            Nombre = "FertilizanteZ",
            FrecuenciaAplicacionDias = 20,
            Valor = 22000,
            FechaUltimaAplicacion = DateTime.Today
        };

        Assert.Equal("ICA78901", producto.RegistroICA);
        Assert.Equal("FertilizanteZ", producto.Nombre);
        Assert.Equal(20, producto.FrecuenciaAplicacionDias);
        Assert.Equal(22000, producto.Valor);
        Assert.Equal(DateTime.Today, producto.FechaUltimaAplicacion);
    }
}
