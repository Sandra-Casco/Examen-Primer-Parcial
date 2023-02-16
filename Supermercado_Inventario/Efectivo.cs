using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado_Inventario
{
    class Efectivo : MedioPago
    {
        public override void RealizarPago(decimal monto)
        {
            Console.WriteLine($"Se ha realizado un pago en efectivo por un monto de {monto:C}");
        }
    }
}
