using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos
{
    public class ControladorTriangulo
    {
        public bool Validar(Triangulo triangulo)
        {
            bool trianguloValido = true;

            if(triangulo.lado1 > triangulo.lado2 + triangulo.lado3 || triangulo.lado2 > triangulo.lado1 + triangulo.lado3 || triangulo.lado3 > triangulo.lado2 + triangulo.lado1)
            {
                trianguloValido = false;          
            }

            return trianguloValido;
        }

        public string Nomear(Triangulo triangulo) 
        {
            string tipoTriangulo;

            if(triangulo.lado1 == triangulo.lado2 && triangulo.lado2 == triangulo.lado3)
            {
                tipoTriangulo = "Equilátero";
            }
            else if(triangulo.lado1 != triangulo.lado2 && triangulo.lado1 != triangulo.lado3 && triangulo.lado2 != triangulo.lado3)
            {
                tipoTriangulo = "Escaleno";
            }
            else
            {
                tipoTriangulo = "Isósceles";
            }

            return tipoTriangulo;
        }

        public void Registrar(double lado1, double lado2, double lado3, Triangulo triangulo)
        {
            triangulo.lado1 = lado1;
            triangulo.lado2 = lado2;
            triangulo.lado3 = lado3;
        }
    }
}
