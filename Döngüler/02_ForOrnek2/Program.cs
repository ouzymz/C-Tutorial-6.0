// 1 ile 50 arasındaki 50 dahi çift sayilarin toplamını bulan ve ekrana yazdıran program... (for döngüsü ile)

int deger = 0;

for (int i = 1; i <= 50; i++)
{
	if (i%2 == 0)
	{
		deger += i;
		Console.WriteLine(deger);
	}

}

Console.ReadLine();