using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        //Todos
        public string InfoPublica = "Tenho um instagram!";

        //herança
        protected string CorDosOlhos = "Castanho";

        // mesmo projeto (Assembly)
        internal ulong NumeroCelular = 6599559595;

        // herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Gírias";

        // mesma classe ou herança no mesmo projeto (C# >= 7.2)
        private protected string SegredoFamilia = "Exemplo";

        // private é o padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }

    }
}
