public class Desodorante : ProductoNoPerecedero
{
    public string Aroma { get; set; }

    public Desodorante(int cantidad, double precio, string descripcion, string aroma)
        : base(cantidad, precio, descripcion)
    {
        Aroma = aroma;
    }

    public override double CalcularTotal()
    {
        return base.CalcularTotal() * 1.05;
    }

    public override string ToString()
    {
        return $"{Cantidad} {Descripcion} (desodorante, aroma {Aroma})";
    }
}