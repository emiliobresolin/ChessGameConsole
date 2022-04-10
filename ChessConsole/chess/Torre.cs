using ChessConsole.tabuleiro;
using System;

namespace ChessConsole.chess
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor) { }
        public override string ToString()
        {
            return "T";
        }
    }
}