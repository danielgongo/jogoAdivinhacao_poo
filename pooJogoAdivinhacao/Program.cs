﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace pooJogoAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GerenciadorJogo gerenciador = new GerenciadorJogo();

            gerenciador.Jogar();
        }

        
    }
}
