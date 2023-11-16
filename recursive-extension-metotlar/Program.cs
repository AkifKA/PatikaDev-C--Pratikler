namespace recursive_extension_metotlar;

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
