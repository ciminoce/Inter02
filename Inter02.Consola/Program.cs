using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inter02.Clases;

namespace Inter02.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuadrado c = new Cuadrado(10);
            MostrarDatos(c);

            Triangulo t = new Triangulo(15);
            MostrarDatos(t);


            Console.ReadLine();

        }

        private static void MostrarDatos(dynamic poligono)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Tipo polígono: {poligono.GetType().Name}");
                sb.AppendLine($"Cant. lados: {poligono.CantidadLados}");
                sb.AppendLine($"Medida: {poligono.Medida}");
                sb.AppendLine($"Perímetro: {poligono.GetPerimetro()}");
                sb.AppendLine($"Superficie: {poligono.GetSuperficie()}");
                Console.WriteLine(sb.ToString());
            }
            catch (Exception)
            {

                Console.WriteLine($"Excepción arrojada mientra se procesaba un {poligono.GetType().Name}");
            }            
        }
    }
}
