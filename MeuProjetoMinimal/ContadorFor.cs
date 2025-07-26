using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace MeuProjetoMinimal
{
    public class ContadorFor
    {
        public void Contar()
        {
            Console.WriteLine("Contando de 0 a 10:");
            int numero = 1;
            for (int contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine($"{numero} * {contador} = {numero * contador}");
            }

        }
    }

}
