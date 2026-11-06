using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace tombok123
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int[] tomb = { 1, 2, 3, 4, 5 };
            Console.WriteLine(tomb[0]);
            Console.WriteLine(tomb[2]);
            Console.WriteLine(tomb[tomb.Length - 1]); //Ebben a verzióban nem működik a ^

            Console.WriteLine("---------------------------------------------------");

            int[] szamok = new int[5];
            int szam;
            Console.Write("Számok: ");
            for (int i = 0; i < szamok.Length; i++)
            {
                szam = Convert.ToInt32(Console.ReadLine());
                szamok[i] = szam;
            }
            Console.WriteLine();
            Console.WriteLine(string.Join(", ", szamok));

            Console.WriteLine("---------------------------------------------------");

            Array.Reverse(szamok);
            Console.WriteLine(string.Join(", ", szamok));

            Console.WriteLine("---------------------------------------------------");

            Array.Reverse(szamok);
            foreach (int i in szamok)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i}: páros");
                }
                else
                {
                    Console.WriteLine($"{i}: páratlan");
                }

            }

            Console.WriteLine("---------------------------------------------------");

            int[] szamok2 = new int[] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < szamok2.Length; i++)
            {
                szamok2[i] *= 10;
            }
            Console.WriteLine(string.Join(", ", szamok2));


            Console.WriteLine("---------------------------------------------------");

            int pozitivok = 0;
            foreach (int i in szamok)
            {
                if (i > -1)
                {
                    pozitivok += 1;
                }
            }
            Console.WriteLine($"Pozitívok: {pozitivok}");

            Console.WriteLine("---------------------------------------------------");

            if (szamok.Length > 0)
            {
                int osszeg = 0;
                foreach (int i in szamok)
                {
                    osszeg += i;
                }
                double atlag = osszeg * 1.0 / szamok.Length;
                Console.WriteLine($"Összeg: {osszeg}");
                Console.WriteLine($"Átlag: {atlag}");
            }
            else
            {
                Console.WriteLine("A tömb üres");
            }

            Console.WriteLine("---------------------------------------------------");

            if (szamok.Length > 0)
            {
                int max = szamok[0];
                int min = szamok[0];
                foreach (int i in szamok)
                {
                    if (i < min)
                    {
                        min = i;
                    }
                    if (i > max)
                    {
                        max = i;
                    }
                }
                Console.WriteLine($"Max: {max}");
                Console.WriteLine($"Min: {min}");
            }
            else
            {
                Console.WriteLine("A tömb üres");
            }

            Console.WriteLine("---------------------------------------------------");

            for (int i = 0; i < szamok.Length; i += 2)
            {
                if (i == 0)
                {
                    Console.Write(szamok[i]);
                }
                else
                {
                    Console.Write(", " + szamok[i]);
                }
            }

            Console.WriteLine("\n---------------------------------------------------");

            Console.Write("Keresett: ");
            int keresett = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ezen az indexen van: {Array.IndexOf(szamok, keresett)}");

            Console.WriteLine("---------------------------------------------------");

            Console.Write("Keresett: ");
            keresett = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ezen az indexen van: {Array.LastIndexOf(szamok, keresett)}");

            Console.WriteLine("---------------------------------------------------");

            int nagyobb = 0;
            foreach (int i in szamok)
            {
                if (i > 50)
                {
                    nagyobb += 1;
                }

            }
            Console.WriteLine($"50-nél nagyobb számok: {nagyobb}");

            Console.WriteLine("---------------------------------------------------");

            if (szamok.Length > 0)
            {
                int nagyobbmintatlag = 0;
                int osszeg = 0;
                foreach (int i in szamok)
                {
                    osszeg += i;
                }
                double atlag = osszeg * 1.0 / szamok.Length;
                foreach (int i in szamok)
                {
                    if (atlag < i)
                    {
                        nagyobbmintatlag += 1;
                    }
                }
                Console.WriteLine($"Nagyobb mint az átlag: {nagyobbmintatlag} db");
            }
            else
            {
                Console.WriteLine("A tömb üres");
            }

            Console.WriteLine("---------------------------------------------------");

            Console.Write("Tömb hossza: ");
            int hossz = Convert.ToInt32(Console.ReadLine());
            int[] tomb123;
            tomb123 = new int[hossz];
            for (int i = 0; i < hossz; i++)
            {
                Console.Write($"{i + 1}. elem: ");
                int szamATombhoz = Convert.ToInt32(Console.ReadLine());
                tomb123[i] = szamATombhoz;
            }
            Console.WriteLine("Eredeti: " + string.Join(", ", tomb123));

            (tomb123[0], tomb123[tomb123.Length - 1]) = (tomb123[tomb123.Length - 1], tomb123[0]);

            //int elso = tomb[0];
            //int utolso = tomb[tomb.Length - 1];
            //tomb[0] = utolso;
            //tomb[tomb.Length - 1] = elso;
            Console.WriteLine("Új: " + string.Join(", ", tomb123));

            //Console.WriteLine("---------------------------------------------------");

            //Console.Write("Tömb hossza: ");
            //int hossz2 = Convert.ToInt32(Console.ReadLine());
            //int[] tomb2;
            //tomb2 = new int[hossz2];
            //for (int i = 0; i < hossz2; i++)
            //{
            //    Console.Write($"{i + 1}. elem: ");
            //    int szamATombhoz2 = Convert.ToInt32(Console.ReadLine());
            //    tomb2[i] = szamATombhoz2;
            //}

            //Array.Sort(tomb2);

            //int masodiklegnagyobb = tomb2[tomb2.Length - 1];
            //for (int i = tomb2[tomb2.Length-1];i < tomb2.Length; i--)
            //{
            //    if(i != tomb2[tomb2.Length-1])
            //    {
            //        masodiklegnagyobb = i;
            //        break;
            //    }
            //}
            //if (masodiklegnagyobb == tomb2[tomb2.Length - 1]){
            //    Console.WriteLine("Minden elem egyenlő!");
            //}
            //else
            //{
            //    Console.WriteLine($"Második legnagyobb: {masodiklegnagyobb}");
            //}

            //Console.WriteLine("---------------------------------------------------");

            //bool  van = false;
            //foreach(int i in tomb2)
            //{
            //    foreach (int j in tomb2)
            //    {
            //        if (i == j)
            //        {
            //            van = true;
            //            break;
            //        }
            //    }
            //    if (van)
            //    {
            //        Console.WriteLine("Van duplikáns");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Nincs duplikáns");
            //    }
            //}

            Console.WriteLine("---------------------------------------------------");

            Console.Write("Tömb hossza: ");
            int hossz3 = Convert.ToInt32(Console.ReadLine());
            int[] tomb3;
            tomb3 = new int[hossz3];
            for (int i = 0; i < hossz3; i++)
            {
                Console.Write($"{i + 1}. elem: ");
                int szamATombhoz3 = Convert.ToInt32(Console.ReadLine());
                tomb3[i] = szamATombhoz3;
            }
            Console.WriteLine("Eredeti: " + string.Join(", ", tomb3));

            List<int> harommaloszthato = new List<int> { };

            foreach(int i in tomb3)
            {
                if(i % 3 == 0)
                {
                    harommaloszthato.Add(i);
                }
            }
            if (harommaloszthato.Count() > 0)
            {
                Console.WriteLine("Hárommal osztható: " + string.Join(", ", harommaloszthato));
            }
            else
            {
                Console.WriteLine("Nincs 3-mal osztható elem");
            }
            

            Console.WriteLine("---------------------------------------------------");

            int[] a = {1, 5, 3};
            for (int vege = a.Length - 1; vege > 0; vege--)
            {
                for (int i = 0; i < vege; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        (a[i], a[i + 1]) = (a[i + 1], a[i]);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", a));
        }
    }
}
