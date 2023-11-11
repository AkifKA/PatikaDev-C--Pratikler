using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5;     //1 byte
            sbyte c = 5;    //1 byte

            short s = 5;    //2 byte
            ushort us = 5;  //2 byte

            Int16 i16 = 2;  //2 byte
            int i = 2;      //4 byte
            Int32 i32 = 2;  //4 byte
            Int64 i64 = 2;  //8 byte

            uint ui = 2;    //4 byte
            long l = 4;     //8 byte
            ulong ul = 4;   //8 byte

            // reel sayilar
            float f = 5;    //4 byte
            double d = 5;   //8 byte

            char ch = '2';  //2 byte
            string str = "Akif"; //sinirsiz

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine("Bugünün tarihi:" + " " + dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;


            //string ifadeler
            string str1 = string.Empty;
            str1 = "Akif KARAÖZ";
            string ad = "Akif";
            string soyad = "Karaöz";
            string tamIsim = ad + " " + soyad;
            Console.WriteLine(tamIsim);

            // integer tanımlama şekilleri
            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            //boolean
            bool bool1 = 10 > 2;

            // Değişken dönüşümleri
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger); //2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); //40

            int int22 = int20 + int.Parse(str20);
            Console.WriteLine(int21); //40

            //tarih
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime); //08.11.2023

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2); //08/11/2023

            //saat
            string datetime3 = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(datetime3); // 23:00

            int degisken = 5;
            string degisken2 = "merhaba";
            Console.WriteLine("sayı:");
            int sayi = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("sayı:" + sayi);








        }
    }
}
