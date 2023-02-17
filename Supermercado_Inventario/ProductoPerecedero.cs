public class ProductoPerecedero : IProducto
{
    public int Cantidad { get; set; }
    public double Precio { get; set; }
    public string Descripcion { get; set; }
    public DateTime FechaCaducidad { get; set; }

    public ProductoPerecedero(int cantidad, double precio, string descripcion, DateTime fechaCaducidad)
    {
        Cantidad = cantidad;
        Precio = precio;
        Descripcion = descripcion;
        FechaCaducidad = fechaCaducidad;
    }

    public virtual double CalcularTotal()
    {
        return Cantidad * Precio * 0.75;
    }

    public override string ToString()
    {
        return $"{Cantidad} {Descripcion} (perecedero)";
    }
}
