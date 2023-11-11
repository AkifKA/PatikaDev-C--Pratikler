namespace diziler_array_sinifi_metotlari;

class Program
{
    static void Main(string[] args)
    {
        // Sort
        int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };
        Console.WriteLine("***** Sırasız Sayı Dizisi");
        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

        Console.WriteLine("***** Sıralı Sayı Dizisi");
        Array.Sort(sayiDizisi);


    }
}
