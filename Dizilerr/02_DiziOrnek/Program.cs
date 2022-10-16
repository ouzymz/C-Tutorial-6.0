/*
 n elemanlı bir sayı dizisinde en küçük elemanın bu dizinin kaçıncı
elemanı olduğunu bulan programın algoritma ve akış diyagramını
çiziniz.

*/
Console.WriteLine("Bir sayi dizisinin eleman sayisini giriniz");

int elemanSayisi = Convert.ToInt32(Console.ReadLine());

int[] dizi = new int[elemanSayisi];

for (int i = 0; i < dizi.Length; i++)
{
    Console.WriteLine($"dizinin {i + 1}. terimini giriniz");
    dizi[i] = Convert.ToInt32(Console.ReadLine());

}



int enBuyuk = int.MinValue;
int enKucuk = int.MaxValue;


for (int i = 0; i < dizi.Length; i++)
{
    if (dizi[i] > enBuyuk)
    {

        enBuyuk = dizi[i];  

    }

    if (dizi[i] < enKucuk)
    {

        enKucuk = dizi[i];

    }
}


Console.WriteLine($"dizinin en küçük elemanının sırası {Array.IndexOf(dizi, enKucuk)+ 1}'dir");

Console.WriteLine($"dizinin en büyük elemanının sırası {Array.IndexOf(dizi, enBuyuk) + 1}'dir");

Console.ReadLine();

