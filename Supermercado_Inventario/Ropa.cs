public class Ropa : ProductoNoPerecedero
{
    public string Talla { get; set; }

    public Ropa(int cantidad, double precio, string descripcion, string talla)
        : base(cantidad, precio, descripcion)
    {
        Talla = talla;
    }

    public override double CalcularTotal()
    {
        return base.CalcularTotal() * 1.2;
    }

    public override string ToString()
    {
        return $"{Cantidad} {Descripcion} (ropa, talla {Talla})";
    }
}