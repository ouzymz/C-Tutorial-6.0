/*
 * 
 * 
 * try blogu altında hata vermesi muhtemelen kodlar yazilir
 * catch blogu altinda hata verdiginde yapilacak islemi gireriz
 * break point ile kod akisini takip edebilecegimiz durak noktasi gibi dusunulebilir.
 * 
 * */

//*Derleme Zamani Hatalari (Syntax):

// Console.WriteLine() // noktalı virgul eksik


//string deger = 13; // veri tipi hatası

// Runtime Hatalari

string kullanicidanGelen = Console.ReadLine(); // Kullanicinin girdigi degeri degiskene atadik Sagdaki metot metinsel deger dondurdugu
                                               // için soldaki veri tiği ile uyumludur.

if (kullanicidanGelen.Length == 10)
{
    // kullanicidan gelen deger 10 karakter ise bu bloktaki kodlar calisacak

    long telefonNumarasi;
    bool sonuc = long.TryParse(kullanicidanGelen, out telefonNumarasi); // tryparse string eger long degere donuyorsa bunu bir degiskene atar
                                                                        // sonrasinda 

}

#region trycatch
try
{   // hata alma riskimiz olan kodlar gelecek 
    Console.WriteLine("Lutfen telefon numarasini 10 hane olacak sekilde giriniz basinda sifir olamdan"); 

    long telefonNumarasi = long.Parse(Console.ReadLine());

    Console.WriteLine("tebrikler dogru formatta girdiniz");
}
catch (Exception)
{
    //try icindeki kod hata verirse 
    Console.WriteLine("Dogru formatta telefon numarası girin lütfen");
}

#endregion


#region Try Catch Finally


Console.WriteLine("Lutfen telefon numarasini 10 hane olacak sekilde giriniz basinda sifir olamdan");

string gelenBilgi = Console.ReadLine();

if (gelenBilgi.Length == 10)
{
    try
    {
        long telefonNumarasi = long.Parse(gelenBilgi);
        Console.WriteLine("tebrikler dogru formatta girdiniz");
    }
    catch (Exception)
    {
        Console.WriteLine("10 karakterden oluşan fakat yanlıs foramtta deger girdiniz");
    }
    finally
    {

        Console.WriteLine(" başarılı olsa da olmasa da buraya ugrasin");

    }
}
else
{
    Console.WriteLine(" 10 karakterden farkli girdiniz");

}



#endregion


#region exception sınıflarında bazıları

try
{
    Console.WriteLine("1. sayiyi giriniz");
    int sayi1 = int.Parse(Console.ReadLine());


    Console.WriteLine("2. sayiyi giriniz");
    int sayi2 = int.Parse(Console.ReadLine());

    double sonuc = sayi1 / sayi2;

    Console.WriteLine("Sonuc = " + sonuc);

}
catch (DivideByZeroException ex) // Sıfıra Bölme Hatası

{
    Console.WriteLine(ex.Message);
    
}

catch (FormatException ex) // format hatasi

{
    Console.WriteLine(ex.Message);

}

catch (OverflowException ex) // Taşma Hatası

{
    Console.WriteLine(ex.Message);

}

catch (Exception ex) // diğer hatalarda

{
    Console.WriteLine(ex.Message);

}


#endregion