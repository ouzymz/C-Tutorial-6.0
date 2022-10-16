
// kullanıcıdan alınan 10 tane tam sayıdan en buyuk ve en buyuk en kucugunu bulup ekrana yazdıran program

int[] sayilar = new int[10];
int enbuyuk = int.MinValue;
int enkucuk = int.MaxValue;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Lütfen " + (i + 1) + ". sayıyı giriniz");

    sayilar[i] = Convert.ToInt32(Console.ReadLine());

    if (sayilar[i] < enkucuk)
    {
        enkucuk = sayilar[i];
    }
    if (sayilar[i] > enbuyuk)
    {
        enbuyuk = sayilar[i];
    }

}

Console.WriteLine("enbuyuk sayı = " + enbuyuk + "enkucuk sayı = " + enkucuk);

Console.ReadLine();