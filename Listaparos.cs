using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listaparos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> szamok = new List<int>();
            Random r = new Random();
            for (int i = 0; i < 30; i++)
            {
                int veletlen = r.Next(1, 101); 
                szamok.Add(veletlen);
            }
            int paros = 0;
            foreach (int szam in szamok)
            {
                if (szam % 2 == 0)
                {
                    paros++;
                }
            }

            Console.WriteLine($"A listában ennyi páros szám van: {paros}");
        }
    }
}
