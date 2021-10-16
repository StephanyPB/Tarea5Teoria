using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo10
{
    class Poligonos
    {
        public int Lados { get; set; }
        public double MedidaLados { get; set; }

        public Poligonos()
        {
            Lados = 0;
            MedidaLados = 0;
        }

        public Poligonos(int CantLado, float LongitudLado)
        {
            Lados = CantLado;
            MedidaLados = LongitudLado;
        }
    }
}

