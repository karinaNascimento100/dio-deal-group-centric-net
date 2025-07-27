using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;


namespace MeuProjetoMinimal
{
    public class ArrayLista
    {
        public void Executar()
        {
            Console.WriteLine("Array de inteiros percorrendo com for:");


            // Criação de um array de inteiros com 4 posições
            int[] arrayInteiros = new int[4];

            // Atribuição de valores às posições do array
            arrayInteiros[0] = 10;
            arrayInteiros[1] = 20;
            arrayInteiros[2] = 30;
            arrayInteiros[3] = 40;


            // Percorrendo o array com for e exibindo os valores
            for (int contador = 0; contador < arrayInteiros.Length; contador++)
            {
                Console.WriteLine($"Valor do array na posição {contador} é: {arrayInteiros[contador]}");
            }


            // Percorrendo o array com foreach e exibindo os valores
            Console.WriteLine("Array de inteiros percorrendo com foreach:");

            int contadorForEach = 0; // Variável para controlar a posição no foreach

            foreach (int valor in arrayInteiros)
            {
                Console.WriteLine($"Posição {contadorForEach} do array é: {valor}");
                contadorForEach++;
            }


            // Criação de uma lista de estados e exibição com for
            Console.WriteLine("Lista estados percorrendo com for:");


            List<string> listaEstados = new List<string>(); // Lista de strings para estados

            // Adicionando estados à lista
            listaEstados.Add("São Paulo");
            listaEstados.Add("Rio de Janeiro");
            listaEstados.Add("Minas Gerais");
            listaEstados.Add("Bahia");

            for (int contador = 0; contador < listaEstados.Count; contador++)
            {
                Console.WriteLine($"Posição {contador} da lista é: {listaEstados[contador]}");
            }

            Console.WriteLine("Lista estados percorrendo com foreach:");
            int contadorForEachEstados = 0;

            foreach (string estado in listaEstados)
            {
                Console.WriteLine($"Posição {contadorForEachEstados} da lista é: {estado}");
                contadorForEachEstados++;
            }
        }
    }
}
