Console.Write("Lütfen ortalamalarını almak istediğiniz 1. sayıyı giriniz.");

Double sayi1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Lütfen ortalamalarını almak istediğiniz 2. sayıyı giriniz.");

Double sayi2 = Convert.ToInt32(Console.ReadLine());

Double ort = (sayi1 + sayi2) / 2;

Console.WriteLine("Girdiğiniz 2 sayının ortalaması {0}'dir", ort);
Console.ReadLine();