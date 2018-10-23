using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Menuzinho bacana pro console.
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Olá, bem vindo a minha lista de exercicios. \nDigite uma das opções disponiveis abaixo para ver o exercicio referente. \nOu aperte qualquer outra tecla para sair.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n***********************************************************"
                                + "\n* 01 - Um aplicativo que separe os numeros (1-40)         *"
                                + "\n* com um espaço em branco entre eles.                     *"
                                + "\n* 02 - Um aplicativo que mostre a soma ou igualdade       *"
                                + "\n* entre 'x' e 'y' ja definidos.                           *"
                                + "\n* 03 - O que o codigo a seguir imprime?                   *"
                                + "\n*" + @" Console.WriteLine(*\n**\n***\n****\n*****);             *"
                                + "\n* 04 - O que o codigo a seguir imprimi:                   *"
                                + "\n* Console.Write('*');                                     *"
                                + "\n* Console.Write('***');                                   *"
                                + "\n* Console.WriteLine('*****');                             *"
                                + "\n* Console.Write('****');                                  *"
                                + "\n* Console.WriteLine('**');                                *"
                                + "\n* 05 - Um programa que leia nome, sobrenome e RA e os     *"
                                + "\n* coloque em uma ordem definida e em cores diferentes.    *"
                                + "\n* 06 - Um programa que some, subtraia, multiplique e      *"
                                + "\n* divida numeros digitados pelo usuario.                  *"
                                + "\n* 07 - Um programa que receba como entrada o raio de um   *" 
                                + "\n* círculo e imprima o diâmetro, a circunferência e a área *"
                                + "\n* 08 - Um programa que leia dois números inteiros e       *" 
                                + "\n* determine e verifique se o 1º é um múltiplo do 2º.      *"
                                + "\n* 09 - Um programa que separe um numero de 5 digitos.     *"
                                + "\n* 10 - Um programa calcule o ² e o ³ dos numeros de 0 a   *"
                                + "\n* 10, e imprima os valores em forma de tabela             *"
                                + "\n***********************************************************");
                Console.ForegroundColor = ConsoleColor.White;
                var opçao = Console.ReadLine();
                // Exercicio 1.
                if (opçao == "1")
                { //Com um "Console.Write()" somente.
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Alternativa A da questão 1.");
                    for (int numeros = 1; numeros <= 40; numeros++)
                        Console.Write(numeros + "\t");

                    //Com quatro "Console.Write()".
                    //Lembrando que tambem pode usar o '$"{int ou var ou string} \t"' que funciona igual 'numeros + "\t"'
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n\nAlternativa B da questão 1.");
                    for (int numeros = 1; numeros <= 10; numeros++)
                        Console.Write(numeros + "\t");
                    for (int numeros = 11; numeros <= 20; numeros++)
                        Console.Write(numeros + "\t");
                    for (int numeros = 21; numeros <= 30; numeros++)
                        Console.Write(numeros + "\t");
                    for (int numeros = 31; numeros <= 40; numeros++)
                        Console.Write(numeros + "\t");

                    Console.WriteLine("\n\n");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Aperte qualquer tecla para voltar para o menu.");
                    Console.ReadKey();
                } //Fim do exercicio 1.

                // Exercicio 2.
                else if (opçao == "2")
                {
                    int x = 2;
                    int y = 3;

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("A questão dois possui algumas alternativas (A-D). \nDigite uma das opções disponiveis abaixo para ver a alternativa referente. \nOu aperte qualquer outra tecla para voltar ao menu.");
                    Console.WriteLine("\n*****************************************"
                                    + "\n* X = 2 | Y = 3                         *"
                                    + "\n*                                       *"
                                    + "\n* A - 'x = ' + x                        *"
                                    + "\n* B - 'O valor de x + x é ' + (x + x)   *"
                                    + "\n* C - 'X = '                            *"
                                    + "\n* D - (x + y) + ' = ' + (y + x)         *"
                                    + "\n*****************************************");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n" + "X = " + x);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("O valor de x + x é " + (x + x));
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("X = ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine((x + y) + " = " + (y + x));
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nAperte qualquer tecla para voltar para o menu.");
                    Console.ReadKey();
                } //Fim do exercicio 2.

                // Exercicio 3.
                else if (opçao == "3")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("O codigo apresenta os asteristicos em 5 linhas diferentes\nPrimeiro por causa do .WriteLine e depois por causa dos" + @" \n" + "\n");
                    Console.WriteLine("*\n**\n***\n****\n*****");

                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Aperte qualquer tecla para voltar para o menu.");
                    Console.ReadKey();
                } //Fim do exercicio 3.

                // Exercicio 4.
                else if (opçao == "4")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("O codigo apresenta os asteristicos que nao possuem 'line'\n apos o 'Write' na mesma linha, como pode se observar abaixo.\nColoquei cada linha de asteristico de uma cor para mostrar essa diferença." + "\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("*");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("***");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("*****");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("****");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("**");


                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Aperte qualquer tecla para voltar para o menu.");
                    Console.ReadKey();
                } //Fim do exercicio 4.

                // Exercicio 5.
                else if (opçao == "5")
                {
                    Console.Clear();
                    Console.WriteLine("Como não ficou especificado se era para ter o nome, sobrenome e ra\nJa escritos ou se era para o usuario escrever\nFiz das duas formas, digite 1 ou 2 para acessar.");
                    var opcoescinco = Console.ReadLine();

                    if (opcoescinco == "1" || opcoescinco == "a")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Por favor digite seu nome:");
                        var nomeprimario = Console.ReadLine();
                        Console.WriteLine("Agora por favor digite seu sobrenome:");
                        var sobrenome = Console.ReadLine();
                        Console.WriteLine("Para finalizar, digite seu RA:");
                        var RA = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Clear();
                        Console.Write($"\nAqui estão seus dados: {RA} - ");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write($"{nomeprimario} {sobrenome}");

                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Aperte qualquer tecla para voltar para o menu.");
                        Console.ReadKey();
                    }
                    else if (opcoescinco == "2" || opcoescinco == "b")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        var ra = 318130076;
                        var nome = "Vinicius";
                        var sobrenome = "Carvalho";

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(ra + " - ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(nome + "\t" + sobrenome);

                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Aperte qualquer tecla para voltar para o menu.");
                        Console.ReadKey();
                    }
                    else
                    {
                    }
                } //Fim do exercicio 5.

                // Exercicio 6.
                else if (opçao == "6")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Digite um numero: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    int numeroum = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Digite outro numero: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    int numerodois = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine($"Primeiro Numero: {numeroum}" + $"\nSegundo Numero: {numerodois}");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\nSoma: " + (numeroum + numerodois));
                    Console.WriteLine("Subtração: " + (numeroum - numerodois));
                    Console.WriteLine("Multiplicação: " + (numeroum * numerodois));
                    Console.WriteLine("Divisão: " + (numeroum / numerodois));

                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Aperte qualquer tecla para voltar para o menu.");
                    Console.ReadKey();
                } //Fim do exercicio 6.

                // Exercicio 7.
                else if (opçao == "7")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Digite o raio do circulo por favor:");
                    int raio = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Seu numero: {raio}");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nDiametro: 2*r");
                    Console.WriteLine("Resp: " + (2 * raio));
                    Console.WriteLine("\nCircunferencia: 2*pi*r" );
                    Console.WriteLine("Resp: " + ((2*3.14159265)*raio));
                    Console.WriteLine("\nArea: pi*r²");
                    Console.WriteLine("Resp: " + (3.14159265 * (raio*raio))); 


                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Aperte qualquer tecla para voltar para o menu.");
                    Console.ReadKey();
                } //Fim do exercicio 7.

                // Exercicio 8, vulgo, questão mais chata e demorada.
                else if (opçao == "8")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Digite um numero por favor:");
                    int firstnumero = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite outro numero por favor:");
                    int secondnumero = Convert.ToInt32(Console.ReadLine());

                    if (firstnumero % secondnumero == 0)
                    {
                        Console.Clear();
                        Console.WriteLine($"Primeiro Numero: {firstnumero}" + $"\nSegundo Numero: {secondnumero}");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nO primeiro numero é multiplo do segundo!"); 
                    }
                    else 
                    {
                        Console.Clear();
                        Console.WriteLine($"Primeiro Numero: {firstnumero}" + $"\nSegundo Numero: {secondnumero}");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nO primeiro numero não é multiplo do segundo!");
                    }

                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Aperte qualquer tecla para voltar para o menu.");
                    Console.ReadKey();
                } //Fim do exercicio 8.

                // Exercicio 9.
                else if (opçao == "9")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Por favor digite um numero de 5 digitos: ");
                    int cincodigitos = Convert.ToInt32(Console.ReadLine());
                    int valorAuxiliar;
                    string resultado;

                    //Aqui pego o primeiro digito
                    valorAuxiliar = cincodigitos / 10000;
                    resultado = valorAuxiliar.ToString();
                    //Pego os dois primeiros digitos
                    valorAuxiliar = cincodigitos / 1000;
                    valorAuxiliar = valorAuxiliar % 10; //pego o ultimo digito dos quais separei
                    resultado = resultado + "   " + valorAuxiliar.ToString();
                    //Pego os tres primeiros digitos
                    valorAuxiliar = cincodigitos / 100;
                    valorAuxiliar = valorAuxiliar % 10; //pego o ultimo digito dos quais separei
                    resultado = resultado + "   " + valorAuxiliar.ToString();
                    //Pego os quatro primeiros digitos
                    valorAuxiliar = cincodigitos / 10;
                    valorAuxiliar = valorAuxiliar % 10; //pego o ultimo digito dos quais separei
                    resultado = resultado + "   " + valorAuxiliar.ToString();
                    //Pego o ultimo digito
                    valorAuxiliar = cincodigitos % 10;
                    resultado = resultado + "   " + valorAuxiliar.ToString();

                    Console.Clear();
                    Console.WriteLine($"Seu numero: {cincodigitos}");
                    Console.WriteLine("\n" + resultado);

                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Aperte qualquer tecla para voltar para o menu.");
                    Console.ReadKey();
                } //Fim do exercicio 9

                // Exercicio 10
                else if (opçao == "10")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;

                    int[] numero = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                    int[] quadrado = { 0*0, 1*1, 2*2, 3*3, 4*4, 5*5, 6*6, 7*7, 8*8, 9*9, 10*10 };
                    int[] cubo = { 0 * 0 * 0, 1 * 1 * 1, 2 * 2 * 2, 3 * 3 * 3, 4 * 4 * 4, 5 * 5 * 5, 6 * 6 * 6, 7 * 7 * 7, 8 * 8 * 8, 9 * 9 * 9, 10 * 10 * 10};

                    Console.WriteLine("{0,-10} {1,10} {2,10}\n", "Numero", "Quadrado", "Cubo");
                    for (int ctr = 0; ctr < numero.Length; ctr++)
                        Console.WriteLine("{0,-10} {1,10} {2,10}", numero[ctr], quadrado[ctr], cubo[ctr]);

                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Aperte qualquer tecla para voltar para o menu.");
                    Console.ReadKey();
                } //Fim do exercicio 10.

                // Opçao para fechar o programa.
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\nTem certeza? Digite 'S' para sair ou 'N' para cancelar..");
                    var resposta = Console.ReadLine();
                    //Caso queira fechar o console mesmo.
                    if (resposta == "S" || resposta == "s")
                    {
                        break;
                    }
                    //Caso nao queira fechar o console.
                    else if (resposta == "N" || resposta == "n")
                    {
                    }
                    //Caso tenha digitado algo diferente de S ou N.
                    else
                    {
                        Console.WriteLine("Ja que nao especificou o programa sera fechado em 5 segundos.");
                        Console.WriteLine("5");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("4");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("3");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("2");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("1");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Adeus");
                        break;
                    }
                }
            }
        }
    }
}
