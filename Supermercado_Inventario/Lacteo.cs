
public class Lacteo : ProductoPerecedero
{
    public int NumeroLote { get; set; }

    public Lacteo(int cantidad, double precio, string descripcion, DateTime fechaCaducidad, int numeroLote)
        : base(cantidad, precio, descripcion, fechaCaducidad)
    {
        NumeroLote = numeroLote;
    }

    public override double CalcularTotal()
    {
        return base.CalcularTotal() * 1.1;
    }

    public override string ToString()
    {
        return $"{Cantidad} {Descripcion} (lácteo, lote {NumeroLote}, caducidad {FechaCaducidad.ToShortDateString()})";
    }
}