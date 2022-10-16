/*
 Methodlar

methodlar 2'ye ayrilir. 
1. Geriye Deger Dondurmeyenler // Consolo.WriteLine();
    1.1 Parametresiz Methodlar
    1.2 Parametreli Methodlar


2. Geriye Deger Dondurenler // (int, string)
    1.1 Parametresiz Methodlar
    1.2 Parametreli Methodlar

Bir kod parcasini, program akisi icerisinde birden fazla yerde kullaniyorsak;
method olusturmasi mantikli olan secenektir. Cunku methot kullanimi ile daha az satirda kod yazilmis daha merkezi kontrol oluşturmuş 
daha temiz kod yazilmis olur
*/

ToplamaYap1();
ToplamaYap2();
ToplamaYap3(35,23,21);






//********************************************************************************//
// Parametresiz ve Geri Donussuz

void ToplamaYap1()
{
    int sayi1, sayi2;
    sayi1 = 25;
    sayi2 = 25;

    int toplam = sayi1 + sayi2;
    Console.WriteLine(toplam);
}

// Parametresiz ve Geri Donuslu

int ToplamaYap2()
{
    int sayi1, sayi2; // sayi1 ve sayi2 local variables
    sayi1 = 15;
    sayi2 = 25;
    int toplam = sayi1 + sayi2;
    return toplam;
}

// Parametreli ve Geri Donussuz

void ToplamaYap3(int gelenSayi1, int gelenSayi2, int gelenSayi3)
{
    int toplam = gelenSayi1 + gelenSayi2 + gelenSayi3;
    Console.WriteLine(toplam);
}

// Parametreli ve Geri Donuslu
///<summary>
///This is a comment
///<para>This is a Paragraph</para>
///</summary>
int ToplamaYap4(int gelenSayi1,int gelenSayi2)
{ 
      return gelenSayi1 + gelenSayi2; 

}


string ToplamaYap5(float sayi1, float sayi2)

{

    float toplam = sayi1 + sayi2;

    return "Toplam: " + toplam;

}

// varsayilan degere sahip Parametreli method
// Kullanicidan adina alan ve ekrana "Merhaba <kullanici>!" seklinde basan bir metot olusturuyoruz. Ancak, kullanici  adi girilmezse
// Merhava Dostum seklinde ekrana bastirsin

void EkranaYaz(string ad)

{
    if (string.IsNullOrEmpty(ad))
        Console.WriteLine("merhaba dostum");
    else
        Console.WriteLine($"merhaba {ad}");
}

void EkranaYaz2(string girilenAd = "Dostum")

{
    Console.WriteLine($"Merhaba{girilenAd}");

}

EkranaYaz2();
EkranaYaz(Console.ReadLine());

//methodlari cagirma işlemini methodun scopelari icinde yapilabilir. Class içinde method tanimlanabilir baska bir methodun icinde olusturlan method cagirilabilir. 

void EkranaYaz3(string input1, string input2, string input3 )
{
    Console.WriteLine("Parametre olarak sirasiyla gelen degerler: {0},{1},{2}", input1, input2, input3);
}

EkranaYaz3("bilge ", "adam ", "akademi.");

EkranaYaz3(input3:"akademi",input2:"adam",input1: "bilge" ); //Sirasiyla yazmak zorunda degiliz. 

