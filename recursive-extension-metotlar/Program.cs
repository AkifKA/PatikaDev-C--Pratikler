﻿namespace recursive_extension_metotlar;

class Program
{
    static void Main(string[] args)
    {
        //? Rekursif - Öz yinemeli Fonksiyomlar/Metotlar
        //? Örnek 3^4 işlemi. 3^4=3*3*3*3
        int result = 1;
        for (int i = 1; i < 5; i++)
        {
            result *= 3;
        }
        Console.WriteLine(result);
        Islemler instance = new Islemler();
        Console.WriteLine(instance.Expo(3,4));

        //? Extension Metotlar
        string ifade = "Akif Karaöz";
        bool sonuc = ifade.CheckSpaces();
        Console.WriteLine(sonuc);
        if (sonuc)
        {
            Console.WriteLine(ifade.RemoveWhiteSpaces());
        }
        Console.WriteLine(ifade.MakeUpperCase());
        Console.WriteLine(ifade.MakeLowerCase());

        int[] dizi = {9,5,3,1,7,4};
        dizi.SortArray();
        dizi.EkranaYazdir();

        int sayi = 50;
       sayi.IsEven();

       string ifade2 = "Patika";
       Console.WriteLine(ifade2.GetFirstCharacter());


        


    }

    public class Islemler
    {
        public int Expo(int sayi, int us)
        {
            if(us<2)
                return sayi;
            return Expo(sayi, us-1)*sayi;
        }
        //? Expo(3,4)
        //? Expo(3,3) * 3
        //? Expo(3,2) * 3 * 3
        //? Expo(3,1) * 3 * 3 * 3
        //?     3 * 3 * 3 * 3     = 3^4
    }
    }

   public static class Extension{
        public static bool CheckSpaces(this string param){
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param){
                string[] dizi = param.Split(" ");
                return string.Join("", dizi);
        }

        public static string MakeUpperCase(this string param){
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param){
            return param.ToLower();
        }
    
    public static int[] SortArray(this int[] param){
        Array.Sort(param);
        return param;
    }
    
    public static void EkranaYazdir(this int[] param){
        foreach (int item in param)
        {
            Console.WriteLine(item);
        }
    }
    public static bool IsEven(this int param)
    {
        bool sonuc = param % 2 == 0;
        if (sonuc)
            Console.WriteLine("{0} çifttir", param);
        else
            Console.WriteLine("{0} tektir", param);
        return sonuc;
    }

    public static string GetFirstCharacter(this string param)
    {
            return param.Substring(0,1);
    }
    
    
    }
 
 


