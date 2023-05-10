﻿using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {

         //   PosicaoXadrez pos = new PosicaoXadrez('c', 7);
          //  Console.WriteLine(pos);
           // Console.WriteLine(pos.toPosicao());
           // Console.ReadLine();
             try { 
             Tabuleiro tab = new Tabuleiro(8,8);

             tab.colocarPeca(new Torre(tab,Cor.Preta), new Posicao(0, 0));
             tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
             tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));
           
             tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(4, 2));
             tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(6, 5));

                Tela.imprimirTabuleiro(tab);
             }
             catch (Exception e) {
                 Console.WriteLine(e.Message);    
             }
            // Console.ReadLine(); 
        }
    }
}
