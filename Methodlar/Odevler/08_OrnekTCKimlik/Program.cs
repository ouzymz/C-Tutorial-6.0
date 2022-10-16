// Girilen TCKimlikNo doğru mu değil mi dönen metotdoğru ise long tipindegönderilen deger

long tcKimlik = 41104925332;

long TCKontrol(long tc)
{

    long toplam13579 = 0, toplam2468 = 0, ilkOnToplam = 0, tcCheck = 0;


    long[] basamaklar = new long[11];
    long tcSabit = tc;
    for (int i = basamaklar.Length - 1; i >= 0; i--)
    {
        
        basamaklar[i] = tc % 10;
        tc = tc / 10;
        if (i % 2 == 1 && i != 9)
        {
            toplam2468 += basamaklar[i];
        }
        if (i % 2 == 0 && i != 10)
        {
            toplam13579 += basamaklar[i];
        }
        if (i < 10)
        {
            ilkOnToplam += basamaklar[i];
        }


        if (((toplam13579 * 7 + toplam2468 * 9) % 10) == basamaklar[9]
            && (toplam13579 * 8) % 10 == basamaklar[10]
            && (ilkOnToplam % 10) == basamaklar[10])
        { tcCheck = tcSabit; }
    }


    return tcCheck;


}


Console.WriteLine(TCKontrol(tcKimlik));
Console.ReadLine();