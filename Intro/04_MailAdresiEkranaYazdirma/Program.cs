

// burası internetten bakıldı..
string TurkishCharacterToEnglish(string text)
{
    char[] turkishChars = { 'ı', 'ğ', 'İ', 'Ğ', 'ç', 'Ç', 'ş', 'Ş', 'ö', 'Ö', 'ü', 'Ü' };
    char[] englishChars = { 'i', 'g', 'i', 'G', 'c', 'C', 's', 's', 'o', 'O', 'u', 'U' };

    // Match chars
    for (int i = 0; i < turkishChars.Length; i++)
        text = text.Replace(turkishChars[i], englishChars[i]);

    return text;
}

Console.Write("Lütfen isminizi giriniz: ");
string isim = Console.ReadLine().ToLower();

isim = TurkishCharacterToEnglish(isim).ToLower();

Console.Write("Lütfen soyisminizi giriniz: ");
string soyisim = Console.ReadLine();

soyisim = TurkishCharacterToEnglish(soyisim).ToLower();

string mail = isim + "." + soyisim + "@gmail.com";

//  Console.WriteLine("Mail adresiniz: " + isim + "." + soyisim + "@gmail.com");

Console.WriteLine("İsim:{0} \nSoyad: {1} \nE-mail: {2}", isim,soyisim,mail);

//  "\n" ile yazdırdığın yazıyı bir alt satıra geçirebilirsin
// .ToLower() : Harfleri tamamen küçük harfe çevirebilirsin
Console.ReadLine();

