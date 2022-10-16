
Personel personel = new Personel();

//personel.AdSetter("Oguzhan"); //personal -. yazdiginda system object classindan miras aldigi methodlar gelir.

Random random = new Random();

random.Next(5,11);


//personel.SoyAd = "Yilmaz";
//Console.WriteLine(personel.SoyAd);

String stringAd = new string("");

personel.Ad = "Oguzhan";
personel.Soyad = "Yilmaz";
personel.CocukSayisi = 0;
personel.Unvan = "Bey";
personel.Yas = 27;

personel.TabanMaas = 10000;

personel.PersonelBilgileriniYaz();



Personel personel2 = new Personel();

personel2.Ad = "Zafer";
personel2.Soyad = "Dorter";
personel2.CocukSayisi = 2;
personel2.Unvan = "Hoca";
personel2.Yas = 38;

personel2.TabanMaas = 10000;

personel2.PersonelBilgileriniYaz();


Console.ReadLine();

// Erisim belirtezi private olan bir field'a disaridan erisemeyiz!! İcerisine veri atmak veta icerisinden veri okumak icin Property'leri kullaniriz.