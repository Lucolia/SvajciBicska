using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Leghosszabbszo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("szavak.txt");
            List<string> szavak = new List<string>();
            for (int i = 0; i < sorok.Length; i++)
            {
                szavak.Add(sorok[i]);
            }
            string leghosszabb = "";
            foreach (string szo in szavak)
            {
                if (szo.Length > leghosszabb.Length)
                {
                    leghosszabb = szo;
                }
            }
            Console.WriteLine($"A leghosszabb szó: {leghosszabb}");
        }
    }
}
