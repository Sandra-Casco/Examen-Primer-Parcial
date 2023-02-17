public class ProductoElectronico : ProductoNoPerecedero
{
    public int Garantia { get; set; }

    public ProductoElectronico(int cantidad, double precio, string descripcion, int garantia) : base(cantidad, precio, descripcion)
    {
        Garantia = garantia;
    }

    public override double CalcularTotal()
    {
        return base.CalcularTotal() * 1.1;
    }

    public override string ToString()
    {
        return $"{Cantidad} {Descripcion} (electrónico, garantía de {Garantia} años)";
    }
}