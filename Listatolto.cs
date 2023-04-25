using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listatolto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>(); 

            Console.WriteLine("Kérlek adj meg egy szöveget!");
            while (true)
            {
                string szoveg = Console.ReadLine(); 

                if (string.IsNullOrWhiteSpace(szoveg)) 
                {
                    break;
                }
                else
                {
                    lista.Add(szoveg); 
                }
            }
        }
    }
}
