namespace donguler_for_loop;

class Program
{
    static void Main(string[] args)
    {

        //Ekrandan girilen sayıya kadar tek olan sayıları ekrana basma
        // Console.Write("Sayı giriniz:");
        // int sayac = int.Parse(Console.ReadLine());

        // for (int i = 1; i <= sayac; i++)
        // {
        //     if (i % 2 == 1)
        //         Console.WriteLine(i);
        // }

        // 1 ile 1000 arasındaki çift ve tek sayıların toplamı
        // int tekSayilarToplami = 0;
        // int ciftSayilarToplami = 0;
        // int genelToplam = 0;

        // for (int i = 1; i <= 1000; i++)
        // {
        //     if (i % 2 == 1)
        //         tekSayilarToplami += i;
        //     if (i % 2 == 0)
        //         ciftSayilarToplami += i;
        // }
        // genelToplam = tekSayilarToplami + ciftSayilarToplami;
        // Console.WriteLine("Tek sayılar Toplamı:" + tekSayilarToplami + " " + "Çift sayılar toplamı:" + " " + ciftSayilarToplami + " " + "Genel Toplam:" + " " + genelToplam);


        // braek, continue
        for (int i = 0; i < 10; i++)
        {
            // if (i == 4)
            //     break;
            // Console.WriteLine(i); 0,1,2,3


            if ((i >= 5) && (i < 7))
                continue;
            Console.WriteLine(i); //0,1,2,3,4,6,7,8,9 (5,6 atladı.)
        }

        //Sonsuz döngü
        // for (; ; )
        // {

        // }





        // bool devam = true;

        // while (devam)
        // {
        //     Console.Write("Bir sayı giriniz: ");
        //     int sayi = Convert.ToInt32(Console.ReadLine());

        //     if (sayi > 0)
        //     {
        //         for (int i = 0; i < sayi; i++)
        //         {
        //             if (i % 2 != 0)
        //                 Console.WriteLine(i);
        //         }

        //         Console.Write("Tekrar işlem yapmak ister misiniz? (e/h): ");
        //         char cevap = Convert.ToChar(Console.ReadLine());

        //         if (char.ToLower(cevap) == 'h')
        //         {
        //             Console.WriteLine("Çıkış yapıldı");
        //             devam = false;
        //         }
        //         else if (char.ToLower(cevap) != 'e')
        //         {
        //             Console.WriteLine("Geçersiz giriş. Çıkış yapıldı.");
        //             devam = false;
        //         }
        //     }
        //     else
        //     {
        //         Console.WriteLine("0'dan büyük bir değer giriniz");
    }
}

















