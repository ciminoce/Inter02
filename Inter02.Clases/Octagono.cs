using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inter02.Clases
{
    public class Octagono:IPoligonoRegular
    {
        public int CantidadLados { get; set; }
        public int Medida { get; set; }

        public Octagono(int medida)
        {
            CantidadLados = 8;
            Medida = medida;
        }
        public double GetPerimetro()
        {
            return Medida * CantidadLados;
        }

        public double GetSuperficie()
        {
            return Medida* Medida *(2 + 2 * Math.Sqrt(2));
        }
    }
}
