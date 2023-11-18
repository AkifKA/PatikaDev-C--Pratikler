namespace odev_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("************** ÖDEV 1 *****************");
        //? SORU 1: Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
      //  Console.Write("Kaç adet sayıda işlem yapmak istiyorsunuz:");
      //   int n = int.Parse(Console.ReadLine());
          
      //?   // List<int> ciftSayilar = new List<int>();
      //?   int[] ciftSayilar = new int[n];

      //   for (int i=0; i<n; i++){
      //     Console.Write("{0}. Sayıyı giriniz:",i+1);
      //      int sayi = int.Parse(Console.ReadLine());
      //?           // ciftSayilar.Add(sayi);
      //           ciftSayilar[i] = sayi;

      //   }
      //  Console.Write("Girmiş olduğunuz {0} adet sayılardan çift olanları şunlardır:",n);
      // foreach (int sayi in ciftSayilar)
      //     if(sayi % 2 ==0)
      //     Console.Write(" "+ sayi + " ");

        //? SORU 2: Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

      // Console.Write("Kaç adet sayı ile işlem yapmak istiyorsunuz:");
      // int n = int.Parse(Console.ReadLine());
      // Console.Write("Hangi sayı ile işlem yapmak istiyorsunuz:");
      // int m = int.Parse(Console.ReadLine());
      // //? List<int> sayilar = new List<int>();
      //? int[] sayilar = new int[n];

      // int sayac = 0;
      // while (sayac<n)
      // {
      //   Console.Write("{0}.sayı:",sayac+1);
      //  int sayi = int.Parse(Console.ReadLine());
      //     //? sayilar.Add(sayi);
      //     sayilar[sayac] = sayi;
      //   sayac++; 
      // }
     
      // Console.Write("Girdiğiniz sayıya eşit olan ya da tam bölünenler:");
      //  foreach (int sayi in sayilar)
      //  {
      //    if (sayi == m || sayi % m == 0)
      //   Console.Write(" " + sayi + " ");
      //  }




        //? Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
        Console.Write("Kelime sayısı giriniz:");
        int n = int.Parse(Console.ReadLine());

        string[] kelimeler = new string[n];
        
        for (int i=0; i<n; i++)
        {
          Console.Write("{0}. kelimeyi giriniz:", i+1);
          string kelime = Console.ReadLine();
          kelimeler[i] = kelime;
        }

       Array.Reverse(kelimeler);
       foreach (string kelime in kelimeler)
       {
        Console.Write(kelime + " ");
       }

        // Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
    }
}
