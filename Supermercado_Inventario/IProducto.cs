using System;
using System.Collections.Generic;

public interface IProducto
{
    int Cantidad { get; set; }
    double Precio { get; set; }
    string Descripcion { get; set; }
    double CalcularTotal();
}
