using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti elementele vectorului: ");
            int[] v = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            QuickSort(v, 0, v.Length - 1);

            Console.WriteLine("Vectorul sortat: " + string.Join(" ", v));
        }
        static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partitie(array, left, right);
                QuickSort(array, left, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, right);
            }
        }
        static int Partitie(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, right);

            return i + 1;
        }
        static void Swap(int[] v, int i, int j)
        {
            int temp = v[i];
            v[i] = v[j];
            v[j] = temp;
        }
    }
}

