using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti primul vector: ");
            int[] v1 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.Write("Introduceti al doilea vector: ");
            int[] v2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] result = MergeSortedArrays(v1, v2);
            Console.WriteLine();
            Console.WriteLine("Vectorul interclasat este:");
            foreach (int num in result)
            {
                Console.Write(num + " ");
            }
        }
        static int[] MergeSortedArrays(int[] v1, int[] v2)
        {
            int[] result = new int[v1.Length + v2.Length];
            int i = 0, j = 0, k = 0;
            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] < v2[j])
                {
                    result[k] = v1[i];
                    i++;
                }
                else
                {
                    result[k] = v2[j];
                    j++;
                }
                k++;
            }
            while (i < v1.Length)
            {
                result[k] = v1[i];
                i++;
                k++;
            }

            while (j < v2.Length)
            {
                result[k] = v2[j];
                j++;
                k++;
            }

            return result;
        }
    }
}
