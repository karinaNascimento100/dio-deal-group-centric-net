using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace MeuProjetoMinimal
{
    public class DoWhile
    {
        int soma = 0;
        int numero = 0;
        public void Somar()
        {
            do
            {
                Console.WriteLine("Digite o número que deseja somar: (0 para sair)");
                numero = Convert.ToInt32(Console.ReadLine());
                soma += numero;

            } while (numero != 0);

            Console.WriteLine($"Soma dos números digitados é: {soma}");
        }
    }
}