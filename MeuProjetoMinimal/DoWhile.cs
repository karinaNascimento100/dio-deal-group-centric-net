// Importação de namespaces necessários para funcionalidades básicas, coleções e tarefas
using System;
using System.Collections.Generic;
using System.Threading.Tasks;



// Namespace do projeto, utilizado para organizar as classes
namespace MeuProjetoMinimal
{
    // Classe responsável por somar números usando o laço do-while
    public class DoWhile
    {
        int soma = 0; // Acumulador da soma dos números digitados
        int numero = 0; // Variável para armazenar o número digitado
        // Método que solicita números ao usuário e soma até que seja digitado 0
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