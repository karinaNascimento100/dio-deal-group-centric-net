using System;

namespace MeuProjetoMinimal
{
    public class MenuOpcao
    {
        public void ExibirMenu()
        {
            while (true)
            {
                Console.WriteLine("Menu de Opções:");
                Console.WriteLine("1 - Cadastrar cliente:");
                Console.WriteLine("2 - Buscar cliente:");
                Console.WriteLine("3 - Apagar cliente:");
                Console.WriteLine("4 - Encerrar:");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine()!;

                switch (opcao)
                {
                    case "1":
                        // Opção para cadastrar cliente
                        Console.WriteLine("Cadastro do cliente");
                        break;
                    case "2":
                        // Opção para buscar cliente
                        Console.WriteLine("Busca do cliente");
                        break;
                    case "3":
                        // Opção para apagar cliente
                        Console.WriteLine("Apagar cliente");
                        break;
                    case "4":
                        // Opção para encerrar o programa
                        Encerrar();
                        break;
                    default:
                        // Caso o usuário digite uma opção inválida
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine(); // linha em branco entre os menus
            }
        }
        private void Encerrar()
        {
            // Método para encerrar o programa
            Console.WriteLine("Encerrando o programa...");
            Environment.Exit(0);
        }

    }
}

