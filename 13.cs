using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti lungimea vectorului:");
            int n = int.Parse(Console.ReadLine());
            int[]v = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                v[i] = int.Parse(Console.ReadLine());
            }

            InsertionSortAlgorithm(v);
            Console.WriteLine("Vectorul sortat:");
            Afis(v);
        }

        static void InsertionSortAlgorithm(int[] v)
        {
            int n = v.Length;
            for (int i = 1; i < n; ++i)
            {
                int k = v[i];
                int j = i - 1;
                // Muta elementele mai mari decat k cu o pozitie inainte
                while (j >= 0 && v[j] > k)
                {
                    v[j + 1] =v[j];
                    j = j - 1;
                }

                // Plaseaza key in pozitia sa corecta
                v[j + 1] = k;
            }
        }
        static void Afis(int[] v)
        {
            int n = v.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
