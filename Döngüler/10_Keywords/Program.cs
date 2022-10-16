#region Continue;

Console.WriteLine("lütfen bir sayi giriniz");

bool sonuc = int.TryParse(Console.ReadLine(), out int girilenSayi);

int toplam = 0;

if (sonuc)
{
	for (int i = 1; i <= girilenSayi; i++)
	{
		if (i % 2 == 0)
			continue;// koşulda döngüdeki işlemi yapmaz, yoksa toplama devam ettirir.
		toplam += i;
	}

	Console.WriteLine($"1'den girilen sayıya ({girilenSayi}) kadar olan tek sayılarin toplamı = " + toplam);
}

else
{
	Console.WriteLine("Hata tam sayi girilmedi");
}

Console.ReadLine();

#endregion;

#region break ve return

int sayi = 0;

if (sayi < 100)
{
	for (sayi =24; sayi < 50; sayi++)
	{
		if (sayi > 25)
			return; // direkt metodu atlar yani 56. satıra gider gibi düşünebilirsin

	}

	for (sayi = 0; sayi < 50; sayi++)
	{
		if (sayi > 25)
			break; //döngüden çıkar 49. satırdan devam eder.

	}

}
sayi = sayi + 5;
Console.WriteLine(sayi);

Console.ReadLine();


#endregion 

