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
                        Console.WriteLine("Cadastro do cliente");
                        break;
                    case "2":
                        Console.WriteLine("Busca do cliente");
                        break;
                    case "3":
                        Console.WriteLine("Apagar cliente");
                        break;
                    case "4":
                        Encerrar();
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine(); // linha em branco entre os menus
            }
        }

        private void Encerrar()
        {
            Console.WriteLine("Obrigado por usar o sistema!");
            Environment.Exit(0);
        }
    }
}

