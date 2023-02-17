public class Harina : ProductoPerecedero
{
    public string Tipo { get; set; }

    public Harina(int cantidad, double precio, string descripcion, DateTime fechaCaducidad, string tipo)
        : base(cantidad, precio, descripcion, fechaCaducidad)
    {
        Tipo = tipo;
    }

    public override double CalcularTotal()
    {
        return base.CalcularTotal() * 1.05;
    }

    public override string ToString()
    {
        return $"{Cantidad} {Descripcion} (harina, tipo {Tipo}, caducidad {FechaCaducidad.ToShortDateString()})";
    }
}
