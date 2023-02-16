using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado_Inventario
{
    class TarjetaCredito_Debito:MedioPago
    {
        public string NumeroTarjeta { get; set; }
        public DateTime FechaExpiracion { get; set; }

        public override void RealizarPago(decimal monto)
        {
            Console.WriteLine($"Se ha realizado un pago con tarjeta de crédito por un monto de {monto:C}");
        }

    }
}
