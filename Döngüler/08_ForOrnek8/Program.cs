Console.WriteLine("Lütfen sayıyı giriniz");

int sayi = Convert.ToInt32(Console.ReadLine());

int control = 0;

for (int i = 1; i < sayi; i++)
{
		
	if (sayi%i==0)
	{
		control+=i;
	}

}

if (control==sayi)
	{
		Console.WriteLine("Girdiğiniz sayı mukemmel sayidir");
	}

Console.ReadLine();