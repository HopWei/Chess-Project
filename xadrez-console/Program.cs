﻿using System;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;

namespace xadrez_console {
    
    class Program {
    public static void Main(string[] args) {

            PosicaoXadrez pos = new PosicaoXadrez('c',7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();
        }
    }
}