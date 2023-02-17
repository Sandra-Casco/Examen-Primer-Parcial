
public class Program
{
    // Sandra Domitila Casco Reyes
    // Examen de la clase de Programación II, I parcial, semana 5
    // Ing. Fernando López

    static void Main(string[] args)
    {
        ICajero cajero = new Cajero();
        Cliente cliente = new Cliente();

        IProducto manzanas = new ProductoNoPerecedero(10, 21.75, "Manzanas");
        IProducto naranjas = new ProductoNoPerecedero(8, 9.35, "Naranjas");
        IProducto celular = new ProductoElectronico(1, 5000.00, "Celular", 2);
        IProducto leche = new Lacteo(2, 53.50, "Leche", new DateTime(2023, 02, 28), 123);
        IProducto pollo = new Carne(1, 198.99, "Pollo", new DateTime(2023, 02, 20), 800);
        IProducto harina = new Harina(1, 36.75, "Harina de trigo", new DateTime(2023, 12, 31), "Integral");
        IProducto pastel = new Pastel(1, 450.00, "Pastel de chocolate", new DateTime(2023, 02, 17), 3);
        IProducto cloro = new ProductoLimpieza(1, 5.50, "Cloro", "Cloralex");
        IProducto camisa = new Ropa(1, 300.00, "Camisa", "M");
        IProducto desodorante = new Desodorante(1, 189.0, "Desodorante", "Fresh");

        cliente.AgregarProducto(manzanas);
        cliente.AgregarProducto(naranjas);
        cliente.AgregarProducto(celular);
        cliente.AgregarProducto(leche);
        cliente.AgregarProducto(pollo);
        cliente.AgregarProducto(harina);
        cliente.AgregarProducto(pastel);
        cliente.AgregarProducto(cloro);
        cliente.AgregarProducto(camisa);
        cliente.AgregarProducto(desodorante);

        cliente.RealizarCompra(cajero);

        Console.WriteLine("Productos comprados:");
        foreach (IProducto producto in cliente.Carrito)
        {
            Console.WriteLine(producto.ToString());
        }

        Console.WriteLine($"El total de ventas es L. {cajero.TotalVentas}");
    }


}