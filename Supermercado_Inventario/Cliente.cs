public class Cliente
{
    public List<IProducto> Carrito { get; set; }

    public Cliente()
    {
        Carrito = new List<IProducto>();
    }

    public void AgregarProducto(IProducto producto)
    {
        Carrito.Add(producto);
    }

    public void RealizarCompra(ICajero cajero)
    {
        foreach (IProducto producto in Carrito)
        {
            cajero.Cobrar(producto);
        }
    }
}