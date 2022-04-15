using ChessConsole.tabuleiro;
using System;

namespace ChessConsole.chess
{
    class PosicaoChess
    {
        public char coluna { get; set; }
        public int linha { get; set; }
        public PosicaoChess() { }

        public PosicaoChess(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }
        public Posicao ToPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
        }
        public override string ToString()
        {
            return "" + coluna + linha;
        }
    }
}
