Console.WriteLine("toplamak istediğiniz sayıalrı sırayla giriniz toplama işlemini bitirmek icin 0 giriniz");

int toplam = 0,giris;

do
{

    giris = Convert.ToInt32(Console.ReadLine());

    toplam += giris;

    Console.WriteLine($"girilen sayıların toplamı : {toplam}");



} while (giris != 0);

Console.ReadLine();

