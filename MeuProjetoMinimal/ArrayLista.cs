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


            int[] arrayInteiros = new int[4];

            arrayInteiros[0] = 10;
            arrayInteiros[1] = 20;
            arrayInteiros[2] = 30;
            arrayInteiros[3] = 40;


            for (int contador = 0; contador < arrayInteiros.Length; contador++)
            {
                Console.WriteLine($"Valor do array na posição {contador} é: {arrayInteiros[contador]}");
            }


            Console.WriteLine("Array de inteiros percorrendo com foreach:");

            int contadorForEach = 0;

            foreach (int valor in arrayInteiros)
            {
                Console.WriteLine($"Posição {contadorForEach} do array é: {valor}");
                contadorForEach++;
            }


            Console.WriteLine("Lista estados percorrendo com for:");


            List<string> listaEstados = new List<string>();

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
