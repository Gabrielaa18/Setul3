using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti un număr natural: ");
            int n = int.Parse(Console.ReadLine());

            // Inițializare array de marcare a numerelor prime
            bool[] isPrime = new bool[n + 1];
            for (int i = 2; i <= n; i++)
            {
                isPrime[i] = true; // Inițial toate numerele sunt marcate ca fiind prime
            }

            // Aplicarea Ciurului lui Eratostene
            for (int p = 2; p * p <= n; p++)
            {
                if (isPrime[p])
                {
                    // Dacă p este prim, marchează toți multiplii săi ca neprim
                    for (int i = p * p; i <= n; i += p)
                    {
                        isPrime[i] = false;
                    }
                }
            }
            Console.WriteLine($"Numerele prime mai mici sau egale cu {n}sunt :");
            for (int i = 2; i <= n; i++)
            {
                if (isPrime[i])
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
