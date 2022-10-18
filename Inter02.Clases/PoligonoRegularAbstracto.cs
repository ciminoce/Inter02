using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inter02.Clases
{
    public abstract class PoligonoRegularAbstracto
    {
        public int CantidadLados { get; set; }
        public int Medida { get; set; }

        public PoligonoRegularAbstracto(int lados, int medida)
        {
            CantidadLados = lados;
            Medida = medida;
        }

        public int GetPerimetro()
        {
            return Medida * CantidadLados;
        }

        public abstract double GetSuperficie();
    }
}
