// kullanımı:
// kontrolEdilecekDeger (KarşılaştırmaOperatörü)  karsilastirilacakDeger ? Koşulun Doğru olması durumu : koşulun yanlış olması durumu

#region Ornek 1
Console.WriteLine("Lutfen Adınızı Giriniz: ");
string inputAd = Console.ReadLine();

Console.WriteLine(inputAd == "Bilge Adam" ? "Girilen ad ile belirlenen ad eşleşmektedir" : "Yanlis isim girilmistir");

#endregion

#region Ornek 2


Console.WriteLine("Iki sayi giriniz");
int sayi1 = Convert.ToInt32(Console.ReadLine());

int sayi2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(sayi1 > sayi2 ? sayi1 + " " + sayi2 + "'den büyüktür": sayi2 + " " + sayi1 + "'den büyüktür");

#endregion