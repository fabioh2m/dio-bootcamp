using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio.Model
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");

        }

        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);

            Console.WriteLine($"{x}^{y} = {pot}");
        }

        public void Seno(int angulo)
        {
            double radiano = (angulo * Math.PI) / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"O seno de {angulo}° é {Math.Round(seno, 4)}");
        }

        public void Coseno(int angulo)
        {
            double radiano = (angulo * Math.PI) / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"O cosseno de {angulo}° é {Math.Round(coseno, 4)}");
        }
        public void Tangente(int angulo)
        {
            double radiano = (angulo * Math.PI) / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"A tangente de {angulo}° é {Math.Round(tangente, 4)}");
        }  
        
        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"A raiz quadrada de {x} é {Math.Round(raiz, 4)}");
        }
    }
    
}