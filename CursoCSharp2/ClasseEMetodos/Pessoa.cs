using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos
{
    class Pessoa
    {
        public string Nome;
        public int Idade;
        
        public string Apresentar()
        {
            return string.Format(
                $"Olá! Me chamdo {Nome} else tenho {Idade}");
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }
    }
}
