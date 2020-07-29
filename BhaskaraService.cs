using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_logica_programacao4
{
    public class BhaskaraService
    {
        public double NumeroA { get; set; }
        public double NumeroB { get; set; }
        public double NumeroC { get; set; }

        public BhaskaraService()
        {
            Console.WriteLine("Equacao de segundo grau: Ax + Bx + C = 0");

            Console.WriteLine("----------");

            Console.WriteLine("Digite o valor de A: ");
            NumeroA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            NumeroB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            NumeroC = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("----------");
        }

        public void CalcularBhaskara()
        {
            double delta = (NumeroB * NumeroB) - 4 * NumeroA * NumeroC;
            double raiz = Math.Sqrt(delta);
            var x1 = ((-(NumeroB)) + raiz) / (2 * NumeroA);
            var x2 = ((-(NumeroB)) - raiz) / (2 * NumeroA);

            Console.WriteLine($"Valor de x1: {x1}");
            Console.WriteLine($"Valor de x2: {x2}");
        }
    }
}
