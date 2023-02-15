using System;
using System.Collections.Generic;
using System.Linq;

namespace Supermercado_Inventario
    // Sandra Domitila Casco Reyes
    // Examen de la clase de Programación II, I parcial, semana 5
    // Ing. Fernando López
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var leche = new ProductoAlimenticio
            {
                Nombre = "Leche",
                Descripcion = "Leche descremada",
                Precio = 20.0m,
                Cantidad = 10,
                FechaCaducidad = new DateTime(2023, 12, 31),
                CodigoBarras = "1432567890"
            };

            var mantequilla = new ProductoAlimenticio
            {
                Nombre = "Mantequilla Sula",
                Descripcion = "Mantequilla descremada",
                Precio = 40.0m,
                Cantidad = 5,
                FechaCaducidad = new DateTime(2023, 10, 30),
                CodigoBarras = "1234567890"
            };

            var azistin = new ProductoLimpieza
            {
                Nombre = "Azistin Suli",
                Descripcion = "Olor a Lavanda",
                Precio = 70.0m,
                Cantidad = 15,
                FechaCaducidad = new DateTime(2024, 10, 30),
                CodigoBarras = "1345672890"
            };

            var carne = new ProductoCarne
            {
                Nombre = "Carne Molida",
                Descripcion = "Carne de res molida Premium",
                Precio = 170.0m,
                Cantidad = 8,
                FechaCaducidad = new DateTime(2024, 10, 30),
                CodigoBarras = "1395672840"
            };

            var televisor = new ProductoElectronico
            {
                Nombre = "Televisor",
                Descripcion = "Televisor LED 4K",
                Precio = 500.0m,
                Cantidad = 5,
                Marca = "Samsung",
                Modelo = "UE55RU7105"
            };

            
            var cliente = new Cliente
            {
                Nombre = "Sandra Casco",
                Direccion = "Colonia Monterrey",
                CarritoCompras = new List<Producto>()
            };

            
            cliente.AgregarProducto(leche);
            cliente.AgregarProducto(televisor);
            cliente.AgregarProducto(mantequilla);
            cliente.AgregarProducto(azistin);
            cliente.AgregarProducto(carne);
            cliente.MostrarCarritoCompras();


           
            var caja = new Caja
            {
                NumeroCaja = 1,
                MontoTotal = cliente.ObtenerMontoTotal()
            };

            
            var ipago = new PagoConTarjeta
            {
                NumeroTarjeta = "1234567890123456",
                FechaExpiracion = new DateTime(2025, 12, 31)
            };

            cliente.RealizarPago(ipago, caja);

            Console.WriteLine($"El monto total a pagar es: {caja.MontoTotal:C}"); 
            Console.WriteLine($"El pago con tarjeta fue exitoso Sr. {cliente.Nombre}");
            Console.WriteLine($"El saldo actual en la caja {caja.NumeroCaja} es: {caja.MontoTotal:C}");
        }
    }

}