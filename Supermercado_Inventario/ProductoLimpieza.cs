public class ProductoLimpieza : ProductoNoPerecedero
{
    public string Marca { get; set; }

    public ProductoLimpieza(int cantidad, double precio, string descripcion, string marca)
        : base(cantidad, precio, descripcion)
    {
        Marca = marca;
    }

    public override double CalcularTotal()
    {
        return base.CalcularTotal() * 1.1;
    }

    public override string ToString()
    {
        return $"{Cantidad} {Descripcion} (limpieza, marca {Marca})";
    }
}
