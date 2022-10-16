
Random rnd = new Random();
int deger = rnd.Next(100);

int sayac = 1;

Console.WriteLine("0-100 arasında bir tam sayi giriniz");

adim1:

int sayi1 = Convert.ToInt32(Console.ReadLine());

if (sayac != 10 && sayi1 != deger && sayi1 < deger)
{
    Console.WriteLine(" Girdiğiniz sayi rasgele değerden küçüktür tekrar deneyin!! ");
    sayac++;
    goto adim1;
}
else if (sayac != 10 && sayi1 != deger && sayi1 > deger)
{
    Console.WriteLine(" Girdiğiniz sayi rasgele değerden büyüktür tekrar deneyin!! ");
    sayac++;
    goto adim1;
}

else if (sayac == 10)
    Console.WriteLine("Hakkiniz doldu tutulan sayı= " + deger + "'dir");
else if (sayi1 == deger)
    Console.WriteLine(sayac + ". adımda dogru sayiyi buldunuz. Sayı= " + deger);

Console.ReadLine();
