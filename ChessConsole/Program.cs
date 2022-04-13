using ChessConsole.chess;
using ChessConsole.tabuleiro;
using System;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaChess partida = new PartidaChess();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tab);
                    Console.Write("ORIGEM: ");
                    Posicao origem = Tela.lerPosicaoChess().ToPosicao();
                    Console.Write("DESTINO: ");
                    Posicao destino = Tela.lerPosicaoChess().ToPosicao();
                    partida.ExecutaMovimento(origem, destino);
                }

                //PosicaoChess pos = new PosicaoChess('c', 7);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
