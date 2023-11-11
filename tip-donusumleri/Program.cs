﻿using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion (Bilicsiz Donusum)
            Console.WriteLine("*****  Implicit Conversion (Bilicsiz Donusum) *****");
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d:" + d);

            long h = d;
            Console.WriteLine("h:" + h);

            float i = h;
            Console.WriteLine("i:" + i);

            string e = "Akif";
            char f = 'k';

            object g = e + " " + f + " " + d;
            Console.WriteLine("g:" + " " + g);

            // Explicit Conversion (Bilicli Donusum)
            Console.WriteLine("\n*****  Explicit Conversion (Bilicli Donusum) *****");
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:" + " " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:" + " " + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:" + " " + v);

            // ToString Metodu
            Console.WriteLine("\n***** ToString Metodu *****");
            int xx = 6;
            Console.WriteLine("xx:" + " " + xx);

            string yy = xx.ToString();
            Console.WriteLine("yy:" + " " + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz:" + " " + zz);

            // System.Convert
            Console.WriteLine("\n***** System.Convert Sınıfı *****");
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            Toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam:" + " " + Toplam);

            // Parse
            Console.WriteLine("\n***** Parse Method *****");
            ParseMethod();
        }
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);
            Console.WriteLine("Rakam1:" + " " + rakam1);
            Console.WriteLine("Rakam2:" + " " + double1);

        }
    }
}
