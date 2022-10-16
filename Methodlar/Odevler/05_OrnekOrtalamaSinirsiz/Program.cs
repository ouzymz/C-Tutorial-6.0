
// Ortalamayi Bul sinirsiz deger için

double[] degerler = new double[5];

degerler[1] = 15.0;
degerler[0] = 16.0;
degerler[2] = 17.0;
degerler[3] = 18.0;
degerler[4] = 19.0;

string OrtalamaBul(params double[] input)
{
	double sayac = 1;
	double toplam = 0;

    foreach (var item in input)
	{
		toplam += item;
		sayac++;
	}

    double ortalama = toplam / sayac;
	
	return ortalama.ToString();
}

Console.WriteLine(OrtalamaBul(degerler));
Console.ReadLine();