using System;
using System.Collections.Generic;
using System.Text;


namespace Tarea5Teoria.Capitulo10
{
    
        public class Poligon
        {
            private int Lados { get; set; }
            public double MedidaLados { get; set; }

            public Poligon()
            {
                Lados = 0;
                MedidaLados = 0;
            }

            public Poligon(int CantLado, float LongitudLado)
            {
                Lados = CantLado;
                MedidaLados = LongitudLado;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Poligono: \n\tLados del polígono: {Lados}\n\tMedidas de los lados: {MedidaLados}");
            return (sb.ToString());
        }
    
}
