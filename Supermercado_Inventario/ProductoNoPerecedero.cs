public class ProductoNoPerecedero : IProducto
{
    public int Cantidad { get; set; }
    public double Precio { get; set; }
    public string Descripcion { get; set; }

    public ProductoNoPerecedero(int cantidad, double precio, string descripcion)
    {
        Cantidad = cantidad;
        Precio = precio;
        Descripcion = descripcion;
    }

    public virtual double CalcularTotal()
    {
        return Cantidad * Precio;
    }

    public override string ToString()
    {
        return $"{Cantidad} {Descripcion} (no perecedero)";
    }
}