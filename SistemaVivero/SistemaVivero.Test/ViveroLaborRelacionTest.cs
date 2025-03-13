using SistemaVivero.Models;

namespace SistemaVivero.Test;

public class ViveroLaborRelacionTest
{
    [Fact]
    public void Vivero_PuedeTenerMultiplesLabores()
    {
        var vivero = new Vivero
        {
            Codigo = "VIV03",
            TipoCultivo = "Tomate"
        };

        var labor1 = new Labor
        {
            Fecha = new DateTime(2025, 3, 10),
            Descripcion = "Aplicación de fertilizante",
            Vivero = vivero
        };

        var labor2 = new Labor
        {
            Fecha = new DateTime(2025, 3, 12),
            Descripcion = "Control de plagas",
            Vivero = vivero
        };

        vivero.Labores = new List<Labor> { labor1, labor2 };

        var labores = vivero.Labores.ToList();

        Assert.Equal(2, labores.Count);
        Assert.Equal("Aplicación de fertilizante", labores[0].Descripcion);
        Assert.Equal("Control de plagas", labores[1].Descripcion);
    }
}
