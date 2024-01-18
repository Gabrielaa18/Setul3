using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti lungimea vectorului:");
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            Console.WriteLine($"Introduceti {n} elemente:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }
            int cmmd = CalculareCMMD(vector);
            Console.WriteLine($"Cel mai mare divizor comun al elementelor vectorului este: {cmmd}");

        }
        static int CalculareCMMD(int[] vector)
        {
            int cmmd = vector[0];

            for (int i = 1; i < vector.Length; i++)
            {
                cmmd = GasireCMMD(cmmd, vector[i]);

                if (cmmd == 1)
                {
                    break;
                }
            }
            return cmmd;
        }

        static int GasireCMMD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

    }
}

