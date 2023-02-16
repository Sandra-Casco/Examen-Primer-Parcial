using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado_Inventario
{
    abstract class MedioPago
    {
        public abstract void RealizarPago(decimal monto);
    }

}
