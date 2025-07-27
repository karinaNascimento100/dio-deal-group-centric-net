// Importação de namespaces necessários para funcionalidades básicas, coleções e tarefas
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


// Namespace do projeto, utilizado para organizar as classes
namespace MeuProjetoMinimal
{
    // Classe responsável por contar utilizando o laço while
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