using System;
using tabuleiro;
using xadrez.tabuleiro;
using xadrez.xadrez_peca;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));

                Tela.imprimirTabuleiro(tab);
                PosicaoXadrez pos = new PosicaoXadrez('a', 1);
                Console.WriteLine(pos.toPosicao());
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            

            Console.ReadLine();

        }
    }

}
