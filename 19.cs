using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex19
{
    internal class Program
    {
        static int NumarAparitii(int[] s, int[] p)
        {
            int numarAparitii = 0;
            if (s.Length < p.Length)
            {
                return 0; // Nu putem gasi p in  s daca lungimea lui s este mai mica decat cea a lui p
            }
            for (int i = 0; i <= s.Length - p.Length; i++)
            {
                bool ok = true;
                for (int j = 0; j < p.Length; j++)
                {
                    if (s[i + j] != p[j])
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok)
                {
                    numarAparitii++;
                }
            }
            return numarAparitii;
        }
        static void Main(string[] args)
        {
            Console.Write("Introduceti vectorul s: ");
            int[] s = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.Write("Introduceti vectorul p: ");
            int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int rez = NumarAparitii(s, p);
            Console.WriteLine($"Vectorul p apare in vectorul s de {rez} ori.");
        }
    }
}
