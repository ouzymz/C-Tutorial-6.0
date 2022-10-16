using System;
using System.Reflection.Emit;

public class Personel
{


   // Bir sinifin icerisinde field'lar, Property'ler, methodlar yeralabilir.
   //Property

   //Property'i olusturmak icin prob + TAB + TAB
    // public string Ad { get; set; } //property

    // Field: Disariya kapali degiskenlerdir.

    //    private string _ad; //field adlandirilirken _ ile baslanir.
    //    public string Ad //eskiden boyle tanimlamak gerekirdi artik daha kolay.
    //    {
    //        get { return _ad; } // getter method'u
    //        set { _ad = value.ToUpper(); } // setter method'u

    //    }
    //}

    //    private string _ad;

    //    public void AdSetter(string ad)
    //    {
    //        _ad = ad;
    //    }

    //    public string AdGetter()
    //    {
    //        return _ad;
    //    }


    //}


    // II. Yol


    public string Ad { get; set; }

    public string Soyad { get; set; }

    public int Yas { get; set; }

    public string Unvan { get; set; }

    public decimal Maas { get; set; }
    public decimal TabanMaas { get; set; }

    public int CocukSayisi { get; set; }

    public void MaasHesapla()
    {
        if (CocukSayisi == 0)
            Maas = TabanMaas;
        else if (CocukSayisi < 3)
            Maas = TabanMaas * 1.05M;
        else if (CocukSayisi >= 3)
            Maas = TabanMaas * 1.15M;
    }

    public void PersonelBilgileriniYaz ()
    {
        MaasHesapla();
        Console.WriteLine($"Adi: {Ad}\nSoyad: {Soyad}\nYasi: {Yas}\nUnvan: {Unvan}\nMaasi: {Maas}");
    }

}