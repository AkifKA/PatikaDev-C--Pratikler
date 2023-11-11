using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama ve işmlemli atama
            Console.WriteLine("***** Atama ve işmlemli atama ***** ");
            int x = 3;
            int y = 3;
            y = y + 2;
            Console.WriteLine("y:" + y);
            y += 2;
            Console.WriteLine("y2:" + y);
            y /= 1;
            Console.WriteLine("y3:" + y);
            x *= 2;
            Console.WriteLine("x:" + x);

            //Mantıksal Operatörler
            // ||, &&, !
            Console.WriteLine("***** Mantıksal Operatörler ***** ");

            bool isSuccess = true;
            bool isComplete = false;

            if (isSuccess && isComplete)
                Console.WriteLine("Perfect");

            if (isSuccess || isComplete)
                Console.WriteLine("Great");

            if (isSuccess && !isComplete)
                Console.WriteLine("Fine");

            // İlişkisel operatörler
            // <, >, <=, >=, ==, !=
            Console.WriteLine("***** İlişkisel operatörler***** ");

            int a = 3;
            int b = 4;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);

            sonuc = a > b;
            Console.WriteLine(sonuc);

            sonuc = a <= b;
            Console.WriteLine(sonuc);

            sonuc = a >= b;
            Console.WriteLine(sonuc);

            sonuc = a == b;
            Console.WriteLine(sonuc);

            // Aritmatik operatörler
            // +, -, /, *
            Console.WriteLine("***** Aritmatik operatörler***** ");

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sayi1++;
            sonuc1 = sayi1;
            Console.WriteLine(sonuc1);

            //% : mod alır
            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);









        }
    }
}
