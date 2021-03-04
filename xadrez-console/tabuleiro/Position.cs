﻿namespace xadrez_console.tabuleiro
{
    class Position
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }
        public Position(int linha, int coluna)
        {
            this.Linha = linha;
            this.Coluna = coluna;
        }
        public override string ToString()
        {
            return $"{Linha}, {Coluna}";
        }
    }
}
