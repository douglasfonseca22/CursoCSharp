using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos1
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            var comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a TV 50? {0}", comprouTv50);

            var comprouSorverte = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorverte);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou a Tv 32? {0}", comprouTv32);

            Console.WriteLine("Mais saudável? {0}", !comprouSorverte);
        }
    }
}
