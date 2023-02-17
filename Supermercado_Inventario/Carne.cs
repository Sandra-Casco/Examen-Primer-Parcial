public class Carne : ProductoPerecedero
{
    public int Peso { get; set; }

    public Carne(int cantidad, double precio, string descripcion, DateTime fechaCaducidad, int peso)
        : base(cantidad, precio, descripcion, fechaCaducidad)
    {
        Peso = peso;
    }

    public override double CalcularTotal()
    {
        return base.CalcularTotal() * 1.2;
    }

    public override string ToString()
    {
        return $"{Cantidad} {Descripcion} (carne, peso {Peso}g, caducidad {FechaCaducidad.ToShortDateString()})";
    }
}