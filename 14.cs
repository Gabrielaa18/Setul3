using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti lungimea vectorului:");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine($"Introduceti {n} elemente:");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Vectorul initial:");
            AfiseazaVector(v);
            SorteazaVector(v);
            Console.WriteLine("\nVectorul sortat:");
            AfiseazaVector(v);
        }

        static void SorteazaVector(int[] v)
        {
            int n = v.Length;
            int index = 0;
            // Parcurge vectorul si muta valorile nenule la inceput
            for (int i = 0; i < n; i++)
            {
                if (v[i] != 0)
                {
                    // Schimba elementul nenul cu primul element din vector
                    int temp = v[i];
                    v[i] = v[index];
                    v[index] = temp;
                    index++;
                }
            }
        }
        static void AfiseazaVector(int[] v)
        {
            foreach (var element in v)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
