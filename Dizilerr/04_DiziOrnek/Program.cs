/*
 * N elemanlı bir dizi bulunmaktadır. Klavyeden girilen sayılar
diziye, bir tane baştan bir tane sondan olmak üzere
yerleştirilmektedir. Örneğin ilk sayı birinci elemana, ikinci
sayı N’inci elemana, üçüncü sayı ikinci elemana, dördüncü sayı
N-1’inci elemana... şeklinde yerleştirilmektedir. N tane sayıyı
klavyeden okuyup diziye yerleştiren ve diziyi ekranda
görüntüleyen programın algoritma ve akış diyagramını çiziniz.
 * 
 */

Console.WriteLine("Bir sayi dizisinin eleman sayisini giriniz");

int elemanSayisi = Convert.ToInt32(Console.ReadLine());

int[] dizi = new int[elemanSayisi];

int indexNumberSon = elemanSayisi-1;
int indexNumberIlk = 0;
int girilenSayi;

for (int i = 0; i < elemanSayisi; i++)
{
    Console.WriteLine($"dizinin {i + 1}. terimini giriniz");

    girilenSayi = int.Parse(Console.ReadLine());

    if (i % 2 == 0)
    {
        
        dizi[indexNumberIlk] = girilenSayi ;

        indexNumberIlk++;

    }
    if (i % 2 == 1)
    {

        dizi[indexNumberSon] = girilenSayi;
        indexNumberSon --;

    }

}


foreach (var item in dizi)
{
    Console.WriteLine(item);
}

Console.ReadLine();

/*
Console.WriteLine("Lütfen Dizideki eleman sayısını yazınız.");
int n = int.Parse(Console.ReadLine());

int[] sayilar = new int[n];

for (int i = 0; i < sayilar.Length; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"Lütfen {i / 2 + 1}. elemanı giriniz.");
        sayilar[i / 2] = int.Parse(Console.ReadLine());
    }
    else
    {
        Console.WriteLine($"Lütfen {n - i / 2}. elemanı giriniz.");
        sayilar[n - i / 2 - 1] = int.Parse(Console.ReadLine());
    }

}

foreach (int say in sayilar)
{
    Console.WriteLine(say);
}




*/

// console.clear(); consoldaki önce gösterilen yazıları temizler.. 

/*
int[] dizi = new int[5];
int n = 5;
int i;
for (i = 0; i < n; i++)
{
    Console.Write(i + ".Sayıyı Giriniz = ");
    dizi[i] = Convert.ToInt32(Console.ReadLine());
    if ((n - 1) != i)
    {
        Console.Write(n + ".Sayıyı Giriniz = ");
        dizi[n - 1] = Convert.ToInt32(Console.ReadLine());
        n = n - 1;
    }
}
n = 5;
for (i = 0; i < n; i++)
{
    Console.WriteLine(dizi[i]);
}

*/

