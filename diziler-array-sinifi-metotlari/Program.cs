using System.Collections;
using System.Runtime.InteropServices;

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
        Console.WriteLine();

        //? Array Sınıfı Metotları HackerRank Challenge 4
        Console.WriteLine("***** Array Sınıfı Metotları HackerRank Challenge 4 *****");
        long[] array = { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
        long sum2 = 0;
        foreach (var num in array)
            sum2 += num;
        Console.WriteLine(sum2);

        //? Array Sınıfı Metotları HackerRank Challenge 5
        Console.WriteLine("***** Array Sınıfı Metotları HackerRank Challenge 5 *****");
        // The task is to find their comparison points by comparing a[0] with b[0], a[1] with b[1], and a[2] with b[2].
        // If a[i] > b[i], then Alice is awarded 1 point.
        // If a[i] < b[i], then Bob is awarded 1 point.
        // If a[i] = b[i], then neither person receives a point.
        // diziler
        int[] a = { 17, 28, 30, }; // Alex'in örnek dizisi
        int[] b = { 99, 16, 8 }; // Bob'un örnek dizisi

        int counterAlex = 0; // Alex'in sayacı
        int counterBon = 0; // Bob'un sayacı

        for (int i = 0; i < a.Length; i++)
        {
            for (int k = i; k == i; k++)
            {
                if (a[i] > b[k])
                    counterAlex++;
                else if (a[i] < b[k])
                    counterBon++;
                else
                {
                    counterAlex++;
                    counterBon++;
                }
            }
        }



        int[] newArray = new int[2];
        newArray[0] = counterAlex;
        newArray[1] = counterBon;

        foreach (var item in newArray)
            Console.Write(item + " ");
        Console.WriteLine();

        //? Array Sınıfı Metotları HackerRank Challenge 6
        Console.WriteLine("***** Array Sınıfı Metotları HackerRank Challenge 6 *****");

        int[] array2 = { 12222, 101, 22, 3, 99, 4, 6, 65, 98, 111 }; // Örnek dizi
        Console.Write("Sıralanmamış Dizi:" + " ");
        foreach (var item in array2)
            Console.Write(item + " ");
        Console.WriteLine();
        //? Dizi eleman sayısını n'ye atıyoruz:
        int n = array2.Length;
        // Track number of elements swapped during a single array traversal
        int numberOfSwaps = 0;


        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                // Geçici "temp" oluşturup, dizi elemanlarını yer değiştiriyoruz
                int temp;
                if (array2[j] > array2[j + 1])
                {
                    temp = array2[j];
                    array2[j] = array2[j + 1];
                    array2[j + 1] = temp;
                    numberOfSwaps++;
                }

            }
            //? Dizi yer değiştirmeye gerek kalmadan sıralanıyorsa; 
            if (numberOfSwaps == 0)
            {
                break;
            }


        }
        Console.Write("Sıralanmış Yeni Dizi:" + " ");
        foreach (var item in array2)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Array is shorted in {0} swaps", numberOfSwaps);
        Console.WriteLine("First Element is {0}", array2[0]);
        Console.WriteLine("Last Element is {0}", array2[n - 1]);
    }
}










