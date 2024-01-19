


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti primul vector (valori binare): ");
            int[] v1 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.Write("Introduceti al doilea vector (valori binare): ");
            int[] v2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] intersectie = Intersectie(v1, v2);

            int[] reuniune = Reuniune(v1, v2);

            int[] diferentaV1V2 = Diferenta(v1, v2);

            int[] diferentaV2V1 = Diferenta(v2, v1);

            Console.WriteLine("Intersectia: " + string.Join(" ", intersectie));
            Console.WriteLine("Reuniunea: " + string.Join(" ", reuniune));
            Console.WriteLine("Diferenta v1 - v2: " + string.Join(" ", diferentaV1V2));
            Console.WriteLine("Diferenta v2 - v1: " + string.Join(" ", diferentaV2V1));
        }

        static int[] Intersectie(int[] v1, int[] v2)
        {
            int n = Math.Min(v1.Length, v2.Length);
            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                result[i] = v1[i] & v2[i];
            }
            return result;
        }

        static int[] Reuniune(int[] v1, int[] v2)
        {
            int n = Math.Max(v1.Length, v2.Length);
            int[] result = new int[n];

            for (int i = 0; i < v1.Length; i++)
            {
                result[i] = v1[i] | v2[i];
            }

            for (int i = v1.Length; i < v2.Length; i++)
            {
                result[i] = v2[i];
            }

            return result;
        }

        static int[] Diferenta(int[] v1, int[] v2)
        {
            int n = Math.Max(v1.Length, v2.Length);
            int[] result = new int[n];

            for (int i = 0; i < v1.Length; i++)
            {
                result[i] = v1[i] & ~v2[i];
            }

            for (int i = v1.Length; i < v2.Length; i++)
            {
                result[i] = 0; // Elemente in plus din v2
            }

            return result;
        }
    }
}
