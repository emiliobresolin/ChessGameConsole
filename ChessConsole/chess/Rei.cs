using ChessConsole.tabuleiro;
using System;

namespace ChessConsole.chess
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) { }
        public override string ToString()
        {
            return "R";
        }
    }
}
