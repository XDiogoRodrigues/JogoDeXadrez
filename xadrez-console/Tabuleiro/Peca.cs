using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadrez_console;

namespace tabuleiro
{
    class Peca
    {
        public  Posicao PosicaoPeca { get; set; }
        public Cor CorPeca { get; protected set; }
        public int QuantidadeMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; } 

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor)
        {
            this.PosicaoPeca = posicao;
            this.Tab = tab;
            this.CorPeca = cor;
            this.QuantidadeMovimentos = 0;
        }

    }
}
