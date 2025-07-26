using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MeuProjetoMinimal
{

    public class Calculadora
    {
        public void Somar(int a, int b)
        {
            Console.WriteLine($"Somando {a} + {b} = {a + b}");
        }

        public void Subtrair(int a, int b)
        {
            Console.WriteLine($"Subtraindo {a} - {b} = {a - b}");
        }

        public void Multiplicar(int a, int b)
        {
            Console.WriteLine($"Multiplicando {a} * {b} = {a * b}");
        }

        public void Dividir(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Divisão por zero não é permitida.");
            }
            Console.WriteLine($"Dividindo {a} / {b} = {a / b}");
        }

        public void Potencia(double a, double b)
        {
            Console.WriteLine($"Elevando {a} ^ {b} = {Math.Pow(a, b)}");
        }

        public void Seno(double angulo)
        {
            double radianos = angulo * (Math.PI / 180);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(Math.Sin(radianos), 4)}");
        }

        public void Cosseno(double angulo)
        {
            double radianos = angulo * (Math.PI / 180);
            Console.WriteLine($"Cosseno de {angulo}° = {Math.Round(Math.Cos(radianos), 4)}");
        }

        public void Tangente(double angulo)
        {
            double radianos = angulo * (Math.PI / 180);
            Console.WriteLine($"Tangente de {angulo}° = {Math.Round(Math.Tan(radianos), 4)}");
        }

        public void RaizQuadrada(double numero)
        {
            double raiz = Math.Sqrt(numero);
            Console.WriteLine($"Raiz quadrada de {numero} = {Math.Round(raiz, 4)}");

        }
    }
}
