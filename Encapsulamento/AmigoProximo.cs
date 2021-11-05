using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    class AmigoProximo
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("Amigo proximo...");

            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(CorDosOlhos);
            //Console.WriteLine(amiga.NumeroCelular);
            Console.WriteLine(amiga.JeitoDeFalar);
            //Console.WriteLine(SegredoFamilia);
            //Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
