using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti primul vector (separate prin spatiu): ");
            int[] v1 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.Write("Introduceti al doilea vector (separate prin spatiu): ");
            int[] v2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // Converteste vectorii in seturi
            HashSet<int> set1 = new HashSet<int>(v1);
            HashSet<int> set2 = new HashSet<int>(v2);

            // Intersectia
            HashSet<int> intersectie = new HashSet<int>(set1);
            intersectie.IntersectWith(set2);

            // Reuniunea
            HashSet<int> reuniune = new HashSet<int>(set1);
            reuniune.UnionWith(set2);

            // Diferenta v1 - v2
            HashSet<int> diferentaV1V2 = new HashSet<int>(set1);
            diferentaV1V2.ExceptWith(set2);

            // Diferenta v2 - v1
            HashSet<int> diferentaV2V1 = new HashSet<int>(set2);
            diferentaV2V1.ExceptWith(set1);

            // Afisarea rezultatelor
            Console.WriteLine("Intersectia: " + string.Join(" ", intersectie));
            Console.WriteLine("Reuniunea: " + string.Join(" ", reuniune));
            Console.WriteLine("Diferenta v1 - v2: " + string.Join(" ", diferentaV1V2));
            Console.WriteLine("Diferenta v2 - v1: " + string.Join(" ", diferentaV2V1));
        }
    }
}
