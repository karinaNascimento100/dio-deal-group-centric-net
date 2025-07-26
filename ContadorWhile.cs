using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace MeuProjetoMinimal
{
    public class ContadorWhile
    {
        public void Contar()
        {
            Console.WriteLine("Contando de 0 a 10:");
            int numero = 10;
            int contador = 0;
            while (contador <= 10)
            {
                Console.WriteLine($"{contador} Executando: {contador} * {numero} = {contador * numero}");
                contador++;
            }
        }
    }
}