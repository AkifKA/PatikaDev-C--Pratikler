namespace metotlar;

class Program
{
    static void Main(string[] args)
    {
        //? Metot tanımı
        //? erisim belirteci geri_donus_tipi(yoksa void yazılır) metot_adi(parametreListesi/arguman)
        //? {
                //? komutlar
                //? geri donus tipi varsa ve dondurecek bir islem varsa return yazılır.
        //? }

        //? Normal değişken tanımlama
        int a = 2;
        int b = 3;

       Console.WriteLine(a+b); 

        //? Foksiyon / Metot çağırma. Metot: Class içindeki fonksiyon
       int sonuc = Topla(a,b);
       Console.WriteLine(sonuc);

        //? Class ile tanımlama
       Metotlar ornek = new Metotlar();
       ornek.EkranaYazdir(Convert.ToString(sonuc));

        ornek.EkranaYazdir(Convert.ToString(a+b));
        //? referans 
        int sonuc2 = ornek.ArttirveTopla(ref a, ref b);
         ornek.EkranaYazdir(Convert.ToString(sonuc2));
         ornek.EkranaYazdir(Convert.ToString(a+b));


    }

    //? Metot oluşturma
    static int Topla(int deger1, int deger2)
    {
        return (deger1 + deger2);
    }

    //? Class oluşturma
    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirveTopla(ref int deger1, ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }
    }
}
