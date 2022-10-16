//#region Ref Anahtar Kelimesi

///*

// Ref keyword'u kısaca benim iceride basima gelen disarida senin basina gelsin demektir. Ornegin;
//Dizi ref anahtar kelimasi ile yeniden boyutlandirildiginda orjinal dizinin de yeni boyutu belirlenmis olur.

// */


//string[] metinler = new string[5];
//Console.WriteLine("Metinler adli dizinin boyutu: " + metinler.Length);

//Array.Resize(ref metinler, 15);
//Console.WriteLine("Metinler adli dizinin boyutu: " + metinler.Length);

//int aDegeri = 10, bDegeri = 20;
//Console.WriteLine($"Method calistirilmadan onceki aDegeri: {aDegeri}, bDegeri: {bDegeri}");

//DegerleriDegistir(ref aDegeri, ref bDegeri);

//Console.WriteLine($"Method calistirilmadan sonraki aDegeri: {aDegeri}, bDegeri: {bDegeri}");

//// refliyse method disindaki degeri degistirir.

//RefsizDegerleriDegistir(aDegeri, bDegeri); 

//Console.WriteLine($"Refsiz Method calistirildiktan sonraki aDegeri: {aDegeri}, bDegeri: {bDegeri}");

//// refsizse method disindaki degeri degistirmez.

//void DegerleriDegistir(ref int a, ref int b)
//{
//    int gecici = a;
//    a = b;
//    b = gecici;

//}


//#endregion

//#region Methoda parametre gonderme

//int sayi = 5;

//int donenDeger = KaresiniAl(sayi);

//Console.WriteLine(donenDeger);

//int KaresiniAl(int a)
//{
//    return a * a;
//}

//#endregion

//void RefsizDegerleriDegistir(int a, int b)
//{
//    int gecici = a;
//    a = b;
//    b = gecici;

//}


//#region OUT anahtar Kelimesi

//int.TryParse("123", out int result);

//bool mydonenDeger = MyTryParse("123", out int myResult);

//bool MyTryParse(string deger, out int result)
//{
//    bool donusDegeri = false;
//    int donusturulenDeger = 0;
//    try
//    {
//        donusturulenDeger = Convert.ToInt32(deger);
//        donusDegeri = true;
//    }
//    catch (Exception)
//    {


//    }
//    result = donusturulenDeger;
//    return donusDegeri;
//}



//void BolmeIslemiYap(int bolunen, int bolen, out int bolum, out int kalan)
//{

//    // Method [geriye geder dondurmeyen) method oldugu icin ve kalan degerini out ile disariya firlatiyoruz.
//    bolum = bolunen / bolen;
//    kalan = bolunen % bolen;
//}
//#endregion

#region Params anahtar kelimesi

// eğer bir methoda gonderilecek parametre sayisi belli degilse, parans anahtar kelimesini kullaniyoruz. Eger bir methoda sabit degerler de gonderecek ise params ifedesi metdofun
// en sonunda tanimlanir.

double toplamOdenenTutar =  FiyatlariTopla(0.23, 10.99, 20.45, 44.67, 0.25);

Console.WriteLine("Toplam Odemeniiz gereken tutar: " + toplamOdenenTutar);

double FiyatlariTopla(double posetUcreti, params double[] tutarlar)
{
	double toplam = 0;
	
	foreach (var item in tutarlar)
	{
		toplam += item;
	}
	return toplam + posetUcreti;
}

#endregion