using ChessConsole.tabuleiro;
using System;

namespace ChessConsole.chess
{
    class PartidaChess
    {
        public Tabuleiro tab { get; private set; }
        public int turno { get; private set; }
        public Cor jogadorAtual { get; private set; }
        public bool terminada { get; private set; }
        public PartidaChess()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            ColocarPecas();
        }
        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.RetirarPeca(origem);
            p.IncrementarQtdMovimentos();
            Peca pecaCapturada = tab.RetirarPeca(destino);
            tab.ColocarPeca(p, destino);
        }
        public void realizaJogada(Posicao origem, Posicao destino)
        {
            ExecutaMovimento(origem, destino);
            turno++;
            mudaJogador();
        }
        public void validarPosicaoOrigem(Posicao pos)
        {
            if (tab.peca(pos) == null)
            {
                throw new TabuleiroException("Nao existe peca na posicao de origem escolhida!");
            }
            if (jogadorAtual != tab.peca(pos).Cor)
            {
                throw new TabuleiroException("A peca de origem escolhida nao e sua!");
            }
            if (!tab.peca(pos).existeMovimentosPossiveis())
            {
                throw new TabuleiroException("Nao ha movimentos possiveis para a peca de origem escolhida!");
            }
        }
        public void validarPosicaoDestino(Posicao origem, Posicao destino)
        {
            if (!tab.peca(origem).podeMoverPara(destino))
            {
                throw new TabuleiroException("Posicao de destino invalida!");
            }
        }
        private void mudaJogador()
        {
            if (jogadorAtual == Cor.Branca)
            {
                jogadorAtual = Cor.Preta;
            }
            else
            {
                jogadorAtual = Cor.Branca;
            }
        }
        private void ColocarPecas()
        {
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoChess('c', 1).ToPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoChess('a', 1).ToPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoChess('a', 2).ToPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoChess('b', 2).ToPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoChess('c', 2).ToPosicao());
            tab.ColocarPeca(new Rei(tab, Cor.Branca), new PosicaoChess('b', 1).ToPosicao());
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new PosicaoChess('b', 8).ToPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new PosicaoChess('c', 8).ToPosicao());
        }
    }
}
