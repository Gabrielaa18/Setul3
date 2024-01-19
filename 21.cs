using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti primul vector: ");
            string v1 = Console.ReadLine();

            Console.Write("Introduceti al doilea vector: ");
            string v2 = Console.ReadLine();
            // Compararea lexicografic
            int rezultatComparare = string.Compare(v1, v2);

            // Afisarea rezultatului
            if (rezultatComparare < 0)
            {
                Console.WriteLine($"Vectorul '{v1}' este inainte de '{v2}' in ordinea lexicografica.");
            }
            else if (rezultatComparare > 0)
            {
                Console.WriteLine($"Vectorul '{v2}' este inainte de '{v1}' in ordinea lexicografica.");
            }
            else
            {
                Console.WriteLine("Vectorii sunt identici din punct de vedere lexicografic.");
            }
        }
    }
}
