public interface ICajero
{
    double TotalVentas { get; set; }
    void Cobrar(IProducto producto);
}

public class Cajero : ICajero
{
    public double TotalVentas { get; set; }

    public void Cobrar(IProducto producto)
    {
        TotalVentas += producto.CalcularTotal();
    }
}