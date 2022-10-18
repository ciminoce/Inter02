using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inter02.Clases
{
    public class Cuadrado:PoligonoRegular
    {
        public Cuadrado(int medida) : base(4, medida)
        {
        }

        public override int GetSuperficie() => Medida * Medida;
    }
}
