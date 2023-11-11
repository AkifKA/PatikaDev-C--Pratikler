namespace diziler;

class Program
{
    static void Main(string[] args)
    {
        //? Dizi Tanımlama
        // string[] renkler = new string[5];

        // string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

        // int[] dizi;
        // dizi = new int[5];

        //?  Dizilere Değer Atama
        // renkler[0] = "Mavi";
        // dizi[3] = 10;

        // Console.WriteLine(hayvanlar[1]);
        // Console.WriteLine(dizi[3]);
        // Console.WriteLine(renkler[0]);

        //?  Dögüler dizi kullanımı
        //  Klavyeden girilen n adet sayının ortalamasını hesaplayan program

        // Console.WriteLine("Lütfen dizinin eleman sayısını giriniz:");
        // int diziUzunlugu = int.Parse(Console.ReadLine());
        // int[] sayıDizisi = new int[diziUzunlugu];


        // for (int i = 0; i < diziUzunlugu; i++)
        // {
        //     Console.WriteLine("Lütfen {0}. sayıyı giriniz", i + 1);
        //     sayıDizisi[i] = int.Parse(Console.ReadLine());

        // }

        // int toplam = 0;
        // foreach (var sayi in sayıDizisi)
        //     toplam += sayi;

        // Console.WriteLine("Ortlalama:{0}", toplam / diziUzunlugu);

        //? Hackerrank Challange Ödevi
        int[] arr = { -55, -5, -4, -3, -2, -1, 0, 1, 2, 3, 9, 11 };
        int zero = 0;
        int plus = 0;
        int minus = 0;

        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] == 0)
            {
                zero++;
            }
            else if (arr[i] < 0)
            {
                minus++;

            }

            else if (arr[i] > 0)
            {
                plus++;
            }

        }
        double zeroResult = (double)zero / n; ;
        double minusResult = (double)minus / n; ;
        double plusResult = (double)minus / n; ;
        Console.WriteLine($"{zeroResult:F6}");
        Console.WriteLine($"{minusResult:F6}");
        Console.WriteLine($"{plusResult:F6}");
    }
}
