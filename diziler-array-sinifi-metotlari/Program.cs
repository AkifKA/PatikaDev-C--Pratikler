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

        //? Array Sınıfı Metotları HackerRank Challenge 1
        Console.WriteLine("***** Array Sınıfı Metotları HackerRank Challenge *****");
        int[] candles = { 5, 5, 3, 1 };
        int maxHeight = 0;

        int maxHeightCount = 0;

        foreach (int candle in candles)
        {

            if (candle > maxHeight)
            {
                maxHeight = candle;
                maxHeightCount = 1;
            }

            else if (candle == maxHeight)
            {
                maxHeightCount++;
            }
        }

        Console.WriteLine(maxHeightCount);
        //? Array Sınıfı Metotları HackerRank Challenge 2
        Console.WriteLine("***** Array Sınıfı Metotları HackerRank Challenge 2 *****");
        int[] ar = { 5, 5, 3, 1 };
        int sum = 0;
        foreach (var num in ar)
            sum += num;
        Console.WriteLine(sum);

        //? Array Sınıfı Metotları HackerRank Challenge 3
        Console.WriteLine("***** Array Sınıfı Metotları HackerRank Challenge 3 *****");
        int[] arr = { 1, 2, 3, 4, 5 };
        Array.Reverse(arr);
        foreach (var item in arr)
            Console.Write(item + " ");



    }
}










