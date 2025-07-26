using System.Diagnostics;
using MeuProjetoMinimal;



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

MenuOpcao menuopcao = new MenuOpcao();
menuopcao.ExibirMenu();

