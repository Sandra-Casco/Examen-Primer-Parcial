using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado_Inventario
{
    class PagoConTarjeta : IPago
    {
        public string NumeroTarjeta { get; set; }
        public DateTime FechaExpiracion { get; set; }

        public void RealizarPago(decimal monto)
        {
            Console.WriteLine($"Se ha realizado un pago con tarjeta por un monto de {monto:C}");
        }
    }
}
