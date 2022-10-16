

using System.Reflection;

Console.WriteLine("3 basamakli bir sayi giriniz");

double sayi1 = Convert.ToInt32(Console.ReadLine()),
    onlarBasamagi,
    yuzlerBasamagi,
    birlerBasamagi,
    kupBirlerBasamagi,
    kupOnlarBasamagi,
    kupYuzlerBasamagi,
    kupToplam;

birlerBasamagi = sayi1 % 10;
onlarBasamagi = sayi1 % 100 - birlerBasamagi;
yuzlerBasamagi = (sayi1 - (birlerBasamagi + onlarBasamagi * 10)) / 100;

kupBirlerBasamagi = Math.Pow(birlerBasamagi,3);
kupOnlarBasamagi = Math.Pow(onlarBasamagi, 3);
kupYuzlerBasamagi = Math.Pow(yuzlerBasamagi, 3);

kupToplam = kupBirlerBasamagi + kupOnlarBasamagi + kupYuzlerBasamagi;

Console.WriteLine(kupToplam == sayi1 ? "girdiginiz sayinin kupu alinmis basamak sayilari toplami kendisine eşittir" : "Girdiginiz sayinin kupu alinmis basamak sayilari toplami kendisine eşit degildir");

Console.ReadLine();
