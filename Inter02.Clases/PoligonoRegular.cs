using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inter02.Clases
{
    public class PoligonoRegular
    {
        public int CantidadLados { get; set; }
        public int Medida { get; set; }

        public PoligonoRegular(int lados, int medida)
        {
            CantidadLados = lados;
            Medida = medida;
        }

        public int GetPerimetro() => Medida * CantidadLados;

        public virtual int GetSuperficie()
        {
            throw new NotImplementedException();
        }
    }
}
