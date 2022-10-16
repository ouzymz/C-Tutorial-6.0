
string isim = "Oguzhan";
string soyIsim = "Yilmaz";

string MailOlusturma(string ad, string soyad)
{
    return $"{ad.ToLower()}.{soyad.ToLower()}@gmail.com";
}

Console.WriteLine("MailAdresiniz: " + MailOlusturma(isim, soyIsim));
Console.ReadLine();