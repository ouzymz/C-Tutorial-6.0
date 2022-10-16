
// Method Overloading: Ayni isimde birden fazla method tanimlamaya method overloading deniz. Kural olarak, parametrelerin tipi ya da sayisi, yani method imzasi,
//farkli olmalidir.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ortalama Double: " + OrtalamayiBul(12.0, 25.0));

        Console.WriteLine("Ortalama Int: " + OrtalamayiBul(12, 25));

        Console.WriteLine("Ortalma double 3 parametre: " + OrtalamayiBul(52.20, 55.20, 13.12));
    }
    /// <summary>
    /// 2 adet double tipteki sayiyi parametre olarak alip geriye double tipte sonuc dondurur
    /// </summary>
    /// <param name="sayi2"> Ortalamaya dahil edilecek double tipte bir sayı</param>
    /// <param name="sayi3"> Ortalamaya dahil edilecek double tipte bir sayı</param>
    /// <return> Yapılan islem sonucu double tipte bir sonuc dondurur</return>
    static double OrtalamayiBul(double sayi1, double sayi2)
        {
            return (sayi1 + sayi2) / 2;
        }
    /// <summary>
    /// 2 adet int tipteki sayiyi parametre olarak alip geriye int tipte sonuc dondurur
    /// </summary>
    /// <param name="sayi2"> Ortalamaya dahil edilecek int tipte bir sayı</param>
    /// <param name="sayi3"> Ortalamaya dahil edilecek int tipte bir sayı</param>
    /// <return> Yapılan islem sonucu int tipte bir sonuc dondurur</return>
    static int OrtalamayiBul(int sayi1, int sayi2)
        {
            return (sayi1 + sayi2) / 2;
        }
    /// <summary>
    /// 3 adet double tipteki sayiyi parametre olarak alip geriye double tipte sonuc dondurur
    /// </summary>
    /// <param name="sayi1"> Ortalamaya dahil edilecek double tipte bir sayı</param>
    /// <param name="sayi2"> Ortalamaya dahil edilecek double tipte bir sayı</param>
    /// <param name="sayi3"> Ortalamaya dahil edilecek double tipte bir sayı</param>
    /// <return> Yapılan islem sonucu double tipte bir sonuc dondurur</return>
    static double OrtalamayiBul(double sayi1, double sayi2, double sayi3)
    {
        return (sayi1 + sayi2 + sayi3) / 3;
    }

}   

