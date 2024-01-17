using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f;
            Console.WriteLine("Introduceti f: ");
            f = int.Parse(Console.ReadLine());
            if (f == 1)
                P1();//suma elementelor unui vector
            if (f == 2)
                P2();//un vectorc si o val k, prima pozitie pe care apare k
            if (f == 3) P3();//pozitiile pe care apar cea mai mica si cea mai mare valoare din vector
            if (f == 4) P4();//cea mai mica si cea mai mare val si de cate ori apare
            if (f == 5) P5();//un vector cu n elemente, o val e si pozitia k, sa se inverseze valoarea e in vector pe poz k
            if (f == 6) P6();//un vector si o poz k, sa se stearga din vector elementul de pe poz k
            if (f == 7) P7();//reverse-sa se inverseze ordinea elementelor din vector-primul devine ultimul
            if (f == 8) P8();//rotire-rotiti el vecoturlui cu o pozitie spre stanga
            if (f == 9) P9();//rotire k-rotiti el vectorului cu k pozitii spre stanga
            if (f == 10) P10();//cautare binara-e da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k
        }
        static void P1()
        {
            int n;
            Console.WriteLine("Introduceti lungimea vectorului: ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            int s = 0;
            for (int i = 0; i < v.Length; i++)
            {
                s = s + v[i];
            }
            Console.WriteLine($"Suma este {s}");
        }
        static void P2()
        {
            int n;
            Console.WriteLine("Introduceti lungimea vectorului: ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine($"\nIntroduceti {n} elemente:");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Introduceti k: ");
            int k;
            k = int.Parse(Console.ReadLine());
            int t = VerifPoz(v, k);
            if (t != -1)
                Console.WriteLine($"Prima pozitie pe care apare {k} este {t + 1}.");
            else
                Console.WriteLine($"Valoarea {k} nu apare in vector.");
        }
        static int VerifPoz(int[] v, int k)
        {
            for (int i = 0; i < v.Length; i++)
            {
                if (k == v[i])
                    return i;
            }
            return -1;
        }
        static void P3()
        {
            int n;
            Console.WriteLine("Introduceti lungimea vectorului: ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine($"\nIntroduceti {n} elemente: ");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            int pozmaxv = verifMax(v);
            int pozminv = verifMin(v);
            Console.WriteLine($"Pozitia pe care se afla cea mai mare valoare este {pozmaxv}, iar cea mai mica este {pozminv}.");
        }
        static int verifMax(int[] v)
        {
            int maxv = v[0];
            int pozmaxv = 0;
            for (int i = 1; i < v.Length; i++)
            {
                if (v[i] > maxv)
                {
                    maxv = v[i];
                    pozmaxv = i;
                }
            }
            return pozmaxv;
        }
        static int verifMin(int[] v)
        {
            int minv = v[0];
            int pozminv = 0;
            for (int i = 1; i < v.Length; i++)
            {
                if (v[i] < minv)
                {
                    minv = v[i];
                    pozminv = i;
                }
            }
            return pozminv;
        }
        static void P4()
        {
            int n, maxv = 1, minv = 100000;
            Console.WriteLine("Introduceti lungimea vectorului: ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine($"\nIntroduceti {n} elemente: ");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            Verificare(v, maxv, minv);
        }
        static void Verificare(int[] v, int maxv, int minv)
        {
            int k = 1, j = 1;//k numara de cate ori apare minv, j-maxv
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] < minv)
                {
                    minv = v[i];
                    k = 1;
                }
                else
                    if (v[i] == minv)
                    k++;

                if (v[i] > maxv)
                {
                    maxv = v[i];
                    j = 1;
                }
                else
                    if (v[i] == maxv)
                    j++;
            }
            Console.WriteLine($"Cea mai mica valoare este {minv} si apare de {k} ori, cea mai mare valoare este {maxv} si apare de {j} ori.");
        }
        static void P5()
        {
            int n;
            Console.WriteLine("Introduceti lungimea vectorului: ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            int e;
            Console.WriteLine("Introduceti e: ");
            e = int.Parse(Console.ReadLine());

            int k;
            Console.WriteLine("Introduceti k: ");
            k = int.Parse(Console.ReadLine());
            if (k >= 0 && k <= v.Length)
            {
                Inserare(v, e, k);
                Console.WriteLine("Vectorul dupa inserare: ");
                AfisareVector(v);
            }
            else { Console.WriteLine("Introduceti alta pozitie de inserat: "); }
        }
        static void Inserare(int[] v, int e, int k)
        {
            int[] v1 = new int[v.Length + 1];
            for (int i = 0; i < k; i++)
            {
                v1[i] = v[i];
            }
            // Inserează valoarea la poziția k
            v1[k] = e;
            // Copiază restul elementelor în noul vector începând cu poziția k + 1
            for (int i = k + 1; i < v.Length; i++)
            {
                v1[i] = v[i - 1];
            }
            v = v1;
        }
        static void AfisareVector(int[] v)
        {
            foreach (int element in v)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        static void P6()
        {
            int n;
            Console.WriteLine("Introduceti lungimea vectorului: ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine($"\nIntroduceti {n} elemente: ");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            int k;//pozitia
            Console.WriteLine("Introduceti pozitia pentru stergere: ");
            k = int.Parse(Console.ReadLine());

            if (k < 0 || k >= n)
            {
                Console.WriteLine("Introduceti alta valoare pentru pozitie: ");
                return;
            }
            for (int i = k; i < n - 1; i++)
            {
                v[i] = v[i + 1];
            }
            Array.Resize(ref v, n - 1);
            Console.WriteLine("Vectorul final: ");
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.WriteLine();
        }
        static void P7()
        {
            int n;
            Console.WriteLine("Introduceti lungimea vectorului: ");
            n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            Console.WriteLine($"Introduceti {n} elemente: ");
            for (int i = 0; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Vectorul initial:");
            AfisareVector(vector);
            Console.WriteLine("\n");
            InverseazaVector(vector);
            Console.WriteLine("Vectorul inversat:");
            AfisareV(vector);
        }
        static void InverseazaVector(int[] vector)
        {
            int n = vector.Length;
            for (int i = 0; i < n / 2; i++)
            {

                int temp = vector[i];
                vector[i] = vector[n - i - 1];
                vector[n - i - 1] = temp;
            }
        }
        static void AfisareV(int[] vector)
        {
            foreach (var element in vector)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
        static void P8()
        {
            int n;
            Console.WriteLine("Introduceti lungimea vectorului: ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine($"\nIntroduceti {n} elemente: ");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            int primul = v[0];
            for (int i = 0; i < v.Length - 1; i++)
            {
                v[i] = v[i + 1];
            }
            v[v.Length - 1] = primul;
            Console.WriteLine(" ");
            foreach (int numar in v)
            {
                Console.WriteLine(numar + " ");
            }
            Console.WriteLine();

        }
        static void P9()
        {
            int n;
            Console.WriteLine("Introduceti lungimea vectorului: ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine($"\nIntroduceti {n} elemente: ");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            int k;
            Console.WriteLine("Introduceti k: ");
            k = int.Parse(Console.ReadLine());
            int lungimeVector = v.Length;

            // Asigurăm că k este mai mic decât lungimea vectorului
            k = k % lungimeVector;

            // Creăm un vector temporar pentru a stoca primele k elemente
            int[] temp = new int[k];
            Array.Copy(v, temp, k);

            // Mutăm restul elementelor cu k poziții spre stânga
            for (int i = 0; i < lungimeVector - k; i++)
            {
                v[i] = v[i + k];
            }

            // Restaurăm primele k elemente la finalul vectorului
            for (int i = 0; i < k; i++)
            {
                v[lungimeVector - k + i] = temp[i];
            }
            foreach (int numar in v)
            {
                Console.Write(numar + " ");
            }
            Console.WriteLine();
        }
        static void P10()
        {
            int n;
            Console.WriteLine("Introduceti lungimea vectorului: ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine($"\nIntroduceti {n} elemente: ");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nIntroduceti valoarea: ");
            int elementCautat = int.Parse(Console.ReadLine());
            
            int k = CautareBinara(v, elementCautat);
            if (k != -1)
            {
                Console.WriteLine($"Elementul {elementCautat} se afla pe pozitia {k}.");
            }
            else
                Console.WriteLine("Elementul nu apare in vector.");
        }
        static int CautareBinara(int[] v, int elementCautat)
        {
            int stanga = 0;
            int dreapta = v.Length - 1;
            while (stanga <= dreapta)
            {
                int mijloc = stanga + (dreapta - stanga) / 2;
                if (v[mijloc] == elementCautat)
                {
                    return mijloc;
                }
                else
                    if (v[mijloc] > elementCautat)
                {
                    dreapta = mijloc - 1;
                }
                else
                {
                    stanga = mijloc + 1;
                }
            }
            return -1;
        }
    }
}
