namespace metotlar_overloading;

class Program
{
    static void Main(string[] args)
    {
        //? Out parametler
        string sayi = "999";
        int outSayi;
        bool sonuc = int.TryParse(sayi, out outSayi);
        if (sonuc)
        {
            Console.WriteLine("Başarılı!");
            Console.WriteLine(outSayi);
        }
        else
        {
            Console.WriteLine("Başarısız!");
        }

    }
}
