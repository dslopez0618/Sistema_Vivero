using SistemaVivero.Models;

namespace SistemaVivero.Test;

public class LaborTest
{
    [Fact]
    public void CrearLabor_Valida_DeberiaCrearCorrectamente()
    {
        var fecha = new DateTime(2025, 3, 13);
        var labor = new Labor
        {
            Fecha = fecha,
            Descripcion = "Aplicación de abono",
            ViveroId = 1
        };

        Assert.Equal(fecha, labor.Fecha);
        Assert.Equal("Aplicación de abono", labor.Descripcion);
        Assert.Equal(1, labor.ViveroId);
    }

    [Fact]
    public void CrearLabor_SinDescripcion_DeberiaFallar()
    {
        var labor = new Labor
        {
            Fecha = DateTime.Now,
            Descripcion = "",
            ViveroId = 1
        };

        Assert.True(string.IsNullOrWhiteSpace(labor.Descripcion));
    }

    [Fact]
    public void CrearLabor_SinFecha_DeberiaFallar()
    {
        var labor = new Labor
        {
            Fecha = default,
            Descripcion = "Aplicación de plaguicida",
            ViveroId = 1
        };

        Assert.Equal(default, labor.Fecha);
    }
}
