int sayi1, sayi2, sayac1, bolenToplam1, bolenToplam2, sayac2;

Console.WriteLine("lütfen 2 sayi giriniz");

sayi1 = Convert.ToInt32(Console.ReadLine());
sayi2 = Convert.ToInt32(Console.ReadLine());
sayac1 = 1;
sayac2 = 1;
bolenToplam1 = 0;
bolenToplam2 = 0;
tekraret1:

if (sayac1 < sayi1)
{
    if (sayi1 % sayac1 == 0)

        bolenToplam1 += sayac1;
        sayac1++;

    goto tekraret1;
}

tekraret2:

if (sayac2 < sayi2)
{
    if (sayi2 % sayac2 == 0)

        bolenToplam2 += sayac2;
    sayac2++;

    goto tekraret2;
}


if (sayi1 == bolenToplam2 && sayi2 == bolenToplam1)
{
    Console.WriteLine("Iki sayi kardes sayilardir.");
}

else
{
    Console.WriteLine("Iki sayi kardes degildir.");
}

Console.WriteLine(bolenToplam1 +" "+ bolenToplam2);

Console.ReadLine();   