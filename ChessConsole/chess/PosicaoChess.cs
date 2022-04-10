using ChessConsole.tabuleiro;
using System;

namespace ChessConsole.chess
{
    class PosicaoChess
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }
        public PosicaoChess() { }

        public PosicaoChess(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }
        public Posicao ToPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }
        public override string ToString()
        {
            return "" + Coluna + Linha;
        }
    }
}
