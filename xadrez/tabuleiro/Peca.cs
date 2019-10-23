using tabuleiro;

namespace xadrez.tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            this.posicao = null;
            this.tab = tabuleiro;
            this.qtdMovimentos = 0;
            this.cor = cor;
        }

        public void incrementarQtdMovimentos()
        {
            qtdMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();
       
    }
}
