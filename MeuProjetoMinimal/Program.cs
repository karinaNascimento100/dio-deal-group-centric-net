using System.Diagnostics;
using MeuProjetoMinimal;

internal class NewBaseType
{
    private static void Main(string[] args)
    {
        // Instancia e executa operações matemáticas
        Calculadora calculadora = new Calculadora();
        calculadora.Somar(5, 3);
        calculadora.Subtrair(5, 3);
        calculadora.Multiplicar(5, 3);
        calculadora.Dividir(5, 3);
        calculadora.Potencia(2, 3);
        calculadora.Seno(30);
        calculadora.Cosseno(60);
        calculadora.Tangente(45);
        calculadora.RaizQuadrada(16);

        // Instancia e executa contadores com diferentes estruturas de repetição
        // Instancia e executa contador usando for
        ContadorFor contadorFor = new ContadorFor();
        contadorFor.Contar();

        // Instancia e executa contador usando while
        ContadorWhile contadorWhile = new ContadorWhile();
        contadorWhile.Contar();

        // Instancia e executa contador usando break
        ContadorBreak contadorBreak = new ContadorBreak();
        contadorBreak.Contar();

        // Instancia e executa soma com do-while
        DoWhile dowhile = new DoWhile();
        dowhile.Somar();

        // Instancia e executa exemplos de array e lista
        ArrayLista arrayLista = new ArrayLista();
        arrayLista.Executar();

        // Exibe o menu de opções para o usuário
        MenuOpcao menuopcao = new MenuOpcao();
        menuopcao.ExibirMenu();


    }
}

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program : NewBaseType
{
    private string GetDebuggerDisplay()
    {
        return ToString() ?? string.Empty;
    }
}