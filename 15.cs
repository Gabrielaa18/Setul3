using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15
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

            Console.WriteLine("Vectorul initial:");
            Afis(vector);
            Elimina(vector);

            Console.WriteLine("\nVectorul fara duplicate:");
            for (int i = 0; i < n; i++)
                if (vector[i] != 0)
                    Console.Write(vector[i] + " ");
            Console.WriteLine();
        }

        static void Elimina(int[] vector)
        {
            int n = vector.Length;
            for (int i = 0; i < n; i++)
            {
                if (vector[i] != 0)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (vector[j] == vector[i])
                        {
                            vector[j] = 0; // Inlocuim duplicatele cu 0
                        }
                    }
                }
            }
            RearanjeazaV(vector);
        }
        static void RearanjeazaV(int[] vector)
        {
            int n = vector.Length;
            int pozitieZero = 0;
            while (pozitieZero < n && vector[pozitieZero] != 0)
            {
                pozitieZero++;
            }
            for (int i = pozitieZero + 1; i < n; i++)
            {
                if (vector[i] != 0)
                {

                    vector[pozitieZero] = vector[i];
                    vector[i] = 0;


                    while (pozitieZero < n && vector[pozitieZero] != 0)
                    {
                        pozitieZero++;
                    }
                }
            }
        }
        static void Afis(int[] vector)
        {
            foreach (int numar in vector)
            {
                Console.Write(numar + " ");
            }
            Console.WriteLine();
        }
    }
}
