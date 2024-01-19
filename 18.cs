using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18
{
    internal class Program
    {
        static double CalculPolinom(double[] coeficienti, double x)
        {
            double rezultat = 0;
            for (int i = 0; i < coeficienti.Length; i++)
            {
                rezultat += coeficienti[i] * Math.Pow(x, i);
            }
            return rezultat;
        }
        static void Main(string[] args)
        {
            Console.Write("Introduceti gradul polinomului (n): ");
            int n = int.Parse(Console.ReadLine());

            // vector de coeficienti
            double[] coeficienti = new double[n + 1];
            Console.WriteLine("Introduceti coeficientii polinomului de la cel mai mic la cel mai mare grad:");
            for (int i = 0; i <= n; i++)
            {
                Console.Write($"Coeficient pentru x^{i}: ");
                coeficienti[i] = double.Parse(Console.ReadLine());
            }

            // Citirea punctului in care sa se evalueze polinomul
            Console.Write("Introduceti punctul x in care sa se evalueze polinomul: ");
            double punct = double.Parse(Console.ReadLine());

            // Calculul si afisarea rezultatului
            double rezultat = CalculPolinom(coeficienti, punct);
            Console.WriteLine($"Valoarea polinomului in punctul {punct} este: {rezultat}");
        }
    } 
}
