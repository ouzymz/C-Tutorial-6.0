double fiyat, pesin, kredi, faiz, sureAy, odeme, borc, artisMiktari;


Console.WriteLine("lutfen evin fiyatini giriniz");
fiyat = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("lutfen pesin odenen miktari giriniz");
pesin = Convert.ToDouble(Console.ReadLine());

kredi = fiyat - pesin;
borc = kredi;

Console.WriteLine("lutfen aylik faiz oranını (%10 için 10 olacak şekilde) giriniz");
faiz = Convert.ToDouble(Console.ReadLine());
faiz = 1 + (faiz/100);

Console.WriteLine("lutfen kredinin aylık vadesini giriniz");
sureAy = Convert.ToDouble(Console.ReadLine());

odeme = kredi/sureAy;
artisMiktari = 100;

while ( kredi > 0.01 || kredi < -0.01)
{	
	if (kredi > 0)
	{
		odeme += artisMiktari ;

	}	
	else if (kredi < 0)
	{
		odeme -= artisMiktari ;
		artisMiktari /= 2;
	}

	kredi = borc;

	for (int i = 0; i < sureAy; i++)
	{	
		kredi = (kredi * faiz) - odeme; 
	}
}

for (int i = 1; i <= sureAy; i++)
{
				
	borc = 	(borc * faiz) - odeme;
	Console.WriteLine($"{i}. ay sonunda kalan borcunuz : {Math.Round(borc,2)} TL'dir. Aylık odeme ise {Math.Round(odeme,2)}");
}

Console.ReadLine();
