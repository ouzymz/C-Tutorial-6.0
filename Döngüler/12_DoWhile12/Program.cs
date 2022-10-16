
using System.Runtime.InteropServices;

int sayi, sayac = 1;
do
{
    Random random = new Random();

    sayi = random.Next(10);
    if (sayi == 3)
    {
        Console.WriteLine($"{sayi},{sayac}"); 
    }

    sayac++;
} while (sayi != 3);
Console.ReadLine();