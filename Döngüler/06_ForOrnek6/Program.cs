
Console.WriteLine("Lütfen faktoriyelini bulmak istediğiniz sayıyı giriniz");

int sayi = Convert.ToInt32(Console.ReadLine()), faktoriyel=1;

for (int i = 1; i <= sayi; i++)
{
    faktoriyel *= i;
}

Console.WriteLine(faktoriyel);

Console.ReadLine();
