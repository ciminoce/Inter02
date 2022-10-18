using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inter02.Clases
{
    public interface IPoligonoRegular
    {
        int CantidadLados { get; set; }
        int Medida { get; set; }


        double GetPerimetro();
        

        double GetSuperficie();

    }
}
