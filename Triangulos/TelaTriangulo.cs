using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos
{
    public class TelaTriangulo
    {
        public void Registrar(Triangulo triangulo)
        {
            ControladorTriangulo controlador = new ControladorTriangulo();

            Console.WriteLine("Informe o lado X lado do triangulo");
            double lado1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o lado Y lado do triangulo");
            double lado2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o lado Z lado do triangulo");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            controlador.Registrar(lado1, lado2, lado3, triangulo);
        }
    }
}
