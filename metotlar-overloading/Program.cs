namespace metotlar_overloading;

class Program
{
    static void Main(string[] args)
    {
        //? Out parametler
        string sayi = "999";
        int outSayi;
        bool sonuc = int.TryParse(sayi, out outSayi);
        if (sonuc)
        {
            Console.WriteLine("Başarılı!");
            Console.WriteLine(outSayi);
        }
        else
        {
            Console.WriteLine("Başarısız!");
        }

        Metotlar instance = new Metotlar();
        instance.Topla(4,5, out int toplamSonucu);
         Console.WriteLine(toplamSonucu);

         //? Metot Aşırı Yükleme (Over Loading)
         //? Method overloading yani metotların aşırı yüklenmesi metot imzasının değiştirilerek aynı isimdeki metodun birden farklı versiyonun yaratılmasıdır.
         int ifade = 999;
         instance.EkranaYazdir(Convert.ToString(ifade));
         instance.EkranaYazdir(ifade);

         //? Hangisini seçeceğine Metot İmzasına göre karar verir
         //? Metot İmzası: Metot Adı + Parametre Sayısı + parametre: bunların üçü aynı olduğunda hata verir. Overloading olması için biri farklı olmalı

         instance.EkranaYazdir("Akif","Karaöz");


    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a+b;
        }

       public void EkranaYazdir(string veri)
       {
        Console.WriteLine(veri);
       }

    //? Overloading
     public void EkranaYazdir(int veri)
       {
        Console.WriteLine(veri);
       }
    //!  private void EkranaYazdir(int veri)
    //    {
    //     Console.WriteLine(veri);
    //    }
       //? Yukarıda Metot İmzası (Metot Adı, Parametre Sayısı, parametre) aynı olduğu için hata verir, overloading olmaz.

       //!  private string EkranaYazdir(int veri)
    //    {
    //     Console.WriteLine(veri);
    //    }
       //? Yukarıda Metot İmzası (Metot Adı, Parametre Sayısı, parametre) aynı olduğu için hata verir, overloading olmaz.

    //!      public void EkranaYazdir(int veri, int veri2)
    //    {
    //     Console.WriteLine(veri);
    //    }
       //? Yukarıda parametre sayısı farklı olduğundan overloading yapar. 

       public void EkranaYazdir(string veri1, string veri2)
       {
        Console.WriteLine(veri1 + " " + veri2);
       }

    }
     
    }


