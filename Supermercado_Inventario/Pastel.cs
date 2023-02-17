public class Pastel : ProductoPerecedero
{
    public int NumeroCapas { get; set; }

    public Pastel(int cantidad, double precio, string descripcion, DateTime fechaCaducidad, int numeroCapas)
        : base(cantidad, precio, descripcion, fechaCaducidad)
    {
        NumeroCapas = numeroCapas;
    }

    public override double CalcularTotal()
    {
        return base.CalcularTotal() * 1.15;
    }

    public override string ToString()
    {
        return $"{Cantidad} {Descripcion} (pastel, {NumeroCapas} capas, caducidad {FechaCaducidad.ToShortDateString()})";
    }
}

