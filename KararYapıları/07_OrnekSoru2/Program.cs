double sayac = 1, ciftToplam, tekToplam, girilenSayi = 0, oran;

ciftToplam = girilenSayi;
tekToplam = girilenSayi;

while (true)
{
    Console.WriteLine("lütfen sayı " + sayac + ". sayiyi giriniz");
    girilenSayi = Convert.ToInt32(Console.ReadLine());

    if (girilenSayi %2 == 0)
    {        
        ciftToplam += girilenSayi;
    }
    else if (girilenSayi %2 == 1)
    {
        tekToplam += girilenSayi;
    }
    sayac++;
    if (sayac > 20)
        break;
}

oran = ciftToplam / tekToplam;

Console.WriteLine("Girilen sayilarin cift olanlarinin toplami ile tek olanlarinin toplamina orani = " + oran);

Console.ReadLine();        