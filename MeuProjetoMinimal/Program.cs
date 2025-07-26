using System.Diagnostics;
using MeuProjetoMinimal;

internal class NewBaseType
{
    private static void Main(string[] args)
    {
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

        ContadorFor contadorFor = new ContadorFor();
        contadorFor.Contar();

        ContadorWhile contadorWhile = new ContadorWhile();
        contadorWhile.Contar();

        ContadorBreak contadorBreak = new ContadorBreak();
        contadorBreak.Contar();

        DoWhile dowhile = new DoWhile();
        dowhile.Somar();

        ArrayLista arrayLista = new ArrayLista();
        arrayLista.Executar();

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