

Console.WriteLine("Lütfen 2 sayı giriniz");

int sayi1 = Convert.ToInt32(Console.ReadLine());
int sayi2 = Convert.ToInt32(Console.ReadLine()), carpim=0;

for (int i = 1; i <= sayi2; i++)
{

    carpim += sayi1;

}

Console.WriteLine(carpim);

Console.ReadLine();