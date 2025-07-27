// Importação de namespaces necessários para funcionalidades básicas, coleções e tarefas
using System;
using System.Collections.Generic;
using System.Threading.Tasks;



// Namespace do projeto, utilizado para organizar as classes
namespace MeuProjetoMinimal
{
    // Classe responsável por contar utilizando o laço for
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
