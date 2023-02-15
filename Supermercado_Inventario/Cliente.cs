using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado_Inventario
{
    class Cliente
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<Producto> CarritoCompras { get; set; }

        public void AgregarProducto(Producto producto)
        {
            CarritoCompras.Add(producto);
        }

        public decimal ObtenerMontoTotal()
        {
            return CarritoCompras.Sum(p => p.CostoTotal); 
        }

        public void RealizarPago(IPago pago, Caja caja)
        {
            pago.RealizarPago(caja.MontoTotal);
        }
        public void MostrarCarritoCompras()
        {
            Console.WriteLine("Carrito de compras:");
            foreach (var producto in CarritoCompras)
            {
                Console.WriteLine($"- {producto.Nombre}: {producto.Cantidad} unidades a {producto.Precio:C} cada una");
            }
        }

    }

}
