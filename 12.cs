using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
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
            SelectionSortAlgorithm(v);
            Console.WriteLine("Vectorul sortat:");
            PrintArray(v);
        }

        static void SelectionSortAlgorithm(int[] v)
        {
            int n = v.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (v[j] < v[minIndex])
                    {
                        minIndex = j;//schimbam valoarea minIndex daca gasim un element mai mic
                    }
                }//schimbam elementul minim cu primul el din vectorul nesortat
                int temp = v[minIndex];
                v[minIndex] =v[i];
                v[i] = temp;
            }
        }
        static void PrintArray(int[] v)
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
     
