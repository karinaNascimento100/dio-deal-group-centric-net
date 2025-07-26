using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace MeuProjetoMinimal
{
    public class ContadorBreak
    {
        public void Contar()
        {
            Console.WriteLine("Contando de 0 a 4:");
            int numero = 10;
            int contador = 0;
            while (contador <= 10)
            {
                Console.WriteLine($"{contador} Executando: {contador} * {numero} = {contador * numero}");

                contador++;

                if (contador == 5)
                {
                    break; // Interrompe a contagem quando contador é igual a 5
                }

            }
        }
    }
}