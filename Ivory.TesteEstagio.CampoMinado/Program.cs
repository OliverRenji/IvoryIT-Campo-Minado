using System;

namespace Ivory.TesteEstagio.CampoMinado
{
    class Program
    {
        static void Main(string[] args)
        {
            var campoMinado = new CampoMinado();
            Console.WriteLine("Início do jogo\n=========");
            Console.WriteLine(campoMinado.Tabuleiro);

            // Realize sua codificação a partir deste ponto, boa sorte!

            //Primeira jogada:
            campoMinado.Abrir(4, 1);
            Console.WriteLine("\n Jogada 1 \n=========");
            Console.WriteLine(campoMinado.Tabuleiro);

            //Segunda jogada:
            campoMinado.Abrir(5, 1);
            Console.WriteLine("\n Jogada 2 \n=========");
            Console.WriteLine(campoMinado.Tabuleiro);

            //Terceira jogada:
            campoMinado.Abrir(5, 2);
            Console.WriteLine("\n Jogada 3 \n=========");
            Console.WriteLine(campoMinado.Tabuleiro);

            //Quarta jogada:
            campoMinado.Abrir(5, 3);
            Console.WriteLine("\n Jogada 4 \n=========");
            Console.WriteLine(campoMinado.Tabuleiro);

            //Quinta jogada:
            campoMinado.Abrir(6, 1);
            Console.WriteLine("\n Jogada 5 \n=========");
            Console.WriteLine(campoMinado.Tabuleiro);

            //Sexta jogada:
            campoMinado.Abrir(5, 6);
            Console.WriteLine("\n Jogada 6 \n=========");
            Console.WriteLine(campoMinado.Tabuleiro);

            //Sétima jogada:
            campoMinado.Abrir(6, 7);
            Console.WriteLine("\n Jogada 7 \n=========");
            Console.WriteLine(campoMinado.Tabuleiro);

            //Jogada final:
            campoMinado.Abrir(6, 9);
            Console.WriteLine("\n Jogada final \n=========");
            Console.WriteLine(campoMinado.Tabuleiro);

            //Checagem de vitória:
            Console.WriteLine(campoMinado.JogoStatus);
        }
    }
}
