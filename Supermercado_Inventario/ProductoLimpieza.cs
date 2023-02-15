using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado_Inventario
{
    public class ProductoLimpieza : Producto
    {
        public DateTime FechaCaducidad { get; set; }
        public string CodigoBarras { get; set; }
    }
}
