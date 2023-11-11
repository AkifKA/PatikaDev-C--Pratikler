namespace donguler_while_foreach;

class Program
{
    static void Main(string[] args)
    {
        // While
        // 1'den başlayarak girilen rakama kadar ortalama hesaplama
        // Console.WriteLine("Sayı giriniz:");
        // int sayi = int.Parse(Console.ReadLine());
        // int sayac = 1;
        // int toplam = 0;
        // double ort = 0;
        // while (sayac <= sayi)
        // {

        //     toplam += sayac;
        //     sayac++;
        // }
        // ort = toplam / sayi;

        // Console.WriteLine("Girilen sayının ortlaması:" + " " + ort);

        // // a'dan z'ye kadar tüm harfleri konsola yazdır
        // char character = 'a';
        // while (character <= 'z')
        // {
        //     Console.Write(character);
        //     character++;
        // }

        // foreach
        string[] arabalar = { "BMW", "Ford", "Nissan" };

        foreach (var araba in arabalar)
        {
            Console.WriteLine(araba);
        }
    }
}
