namespace odev_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("************** ÖDEV 1 *****************");
        //? SORU 1: Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
      //  Console.Write("Kaç adet sayıda işlem yapmak istiyorsunuz:");
      //   int n = int.Parse(Console.ReadLine());
          
      //   List<int> ciftSayilar = new List<int>();

      //   for (int i=1; i<=n; i++){
      //     Console.Write("{0}. Sayıyı giriniz:",i);
      //      int sayi = int.Parse(Console.ReadLine());
      //        if (sayi % 2 ==0)
      //           ciftSayilar.Add(sayi);
      //   }
      //  Console.Write("Girmiş olduğunuz {0} adet sayılardan çift olanları şunlardır:",n);
      // foreach (var item in ciftSayilar)
      //     Console.Write(" "+ item + " ");

        //? SORU 2: Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

      Console.Write("Kaç adet sayı ile işlem yapmak istiyorsunuz:");
      int n = int.Parse(Console.ReadLine());
      Console.Write("Hangi sayı ile işlem yapmak istiyorsunuz:");
      int m = int.Parse(Console.ReadLine());
      //? List<int> sayilar = new List<int>();
      int[] sayilar = new int[n];

      int sayac = 1;
      while (sayac<n)
      {
        Console.Write("{0}. sayı:",sayac);
       int sayi = int.Parse(Console.ReadLine());
        if (sayi == m || sayi % m == 0)
        {
          //? sayilar.Add(sayi);
          sayilar[sayac] = sayi;
        }
        sayac++; 
      }
      Console.Write("{0}'a eşit olan ya da tam bölünenler:", m);
       
       foreach (int item in sayilar)
       {
        Console.Write(" " + item + " ");
       }




        // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
        // Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
    }
}
