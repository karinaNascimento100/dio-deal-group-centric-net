// Importação de namespaces necessários para funcionalidades básicas, coleções e tarefas
using System;
using System.Collections.Generic;
using System.Threading.Tasks;



// Namespace do projeto, utilizado para organizar as classes
namespace MeuProjetoMinimal
{
    // Classe responsável por contar e demonstrar o uso do break em laços
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