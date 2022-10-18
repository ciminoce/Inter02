using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inter02.Clases
{
    public class Triangulo:PoligonoRegularAbstracto
    {
        public Triangulo( int medida) : base(3, medida)
        {
        }

        public override double GetSuperficie()
        {
            return (Math.Sqrt(3) / 4) * Medida*Medida;
        }
    }
}
