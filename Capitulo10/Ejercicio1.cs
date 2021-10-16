using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea5Teoria.Capitulo10
{
    class Producto
    {
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public string Descripcion { get; set; }


        public Producto()
        {
            Nombre = "";
            Codigo = 0;
            Cantidad = 0;
            Descripcion = "";
            Precio = 0.0;
        }

        public Producto(string NombreProducto, int CodigoProducto, int CantidadProducto, string DescripcionProducto, double Precioproducto)
        {
            Nombre = NombreProducto;
            Codigo = CodigoProducto;
            Cantidad = CantidadProducto;
            Descripcion = DescripcionProducto;
            Precio = Precioproducto;
        }
    }
}




