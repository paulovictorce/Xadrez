using tabuleiro;
using xadrez.tabuleiro;

namespace xadrez.xadrez_peca
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}
