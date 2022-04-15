﻿using ChessConsole.chess;
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
                    try
                    {
                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.tab);

                        Console.WriteLine("Turno: " + partida.turno);
                        Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);

                        Console.Write("ORIGEM: ");
                        Posicao origem = Tela.lerPosicaoChess().ToPosicao();
                        partida.validarPosicaoOrigem(origem);
                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.tab, posicoesPossiveis);

                        Console.Write("DESTINO: ");
                        Posicao destino = Tela.lerPosicaoChess().ToPosicao();
                        partida.validarPosicaoDestino(origem, destino);
                        partida.realizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
