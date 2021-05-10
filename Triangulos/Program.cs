using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();
            TelaTriangulo telaTriangulo = new TelaTriangulo();
            ControladorTriangulo controladorTriangulo = new ControladorTriangulo();
            string tipoTriangulo;
            bool trianguloValido;

            telaTriangulo.Registrar(triangulo);

            trianguloValido = controladorTriangulo.Validar(triangulo);

            tipoTriangulo = controladorTriangulo.Nomear(triangulo);

            ApresentarResulado(tipoTriangulo, trianguloValido);

        }

        #region Métodos Privados
        private static void ApresentarResulado(string tipoTriangulo, bool trianguloValido)
        {
            if (trianguloValido)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("\nO triângulo é: " + tipoTriangulo);

                Console.ResetColor();

                Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("\nTriângulo inválido.");

                Console.ResetColor();

                Console.ReadLine();
            }
        }
        #endregion
    }
}
