namespace diziler_array_sinifi_metotlari;

class Program
{
    static void Main(string[] args)
    {
        // Sort
        Console.WriteLine("***** Array Sort ******");
        int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };
        Console.WriteLine("***** Sırasız Sayı Dizisi *****");
        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

        Console.WriteLine("***** Sıralı Sayı Dizisi ******");
        Array.Sort(sayiDizisi);
        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

        //! Clear
        //! Dizinin belirtilen elemanlarını varsayılan değerine getirir. Yani örneğin numeric bir dizi ise 0 olarak setler.
        Console.WriteLine("***** Array Clear ******");
        // sayiDizisi elemanlarını kullanarak 2. index'ten itibaren 2 tane elemanı 0 yapar.
        Array.Clear(sayiDizisi, 2, 2);
        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

        //! Reverse
        //! Diziyi ters çevirir
        Console.WriteLine("***** Array Reverse ******");
        Array.Reverse(sayiDizisi);
        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

        //! IndexOf
        //! Dizinin belirtilen elemanının index numarasını dönderir
        Console.WriteLine("***** Array IndexOf ******");
        Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

        //! Resize
        //! Dizinin lenght'ini yeniden boyutlandırır.(Dizileri yeniden boyutlandırmak için kullanılır.)
        Console.WriteLine("***** Array Resize ******");
        Array.Resize<int>(ref sayiDizisi, 9);
        sayiDizisi[8] = 99;
        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);







    }
}
