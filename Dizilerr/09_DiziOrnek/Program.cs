//İstenildiği kadar elemandan oluşan bir sayı dizisinde negatif ve pozitif
//elemanların sayısını bulan algoritma ve akış diyagramını çiziniz.


Console.WriteLine("Bir sayi dizisinin eleman sayisini giriniz");

int elemanSayisi = Convert.ToInt32(Console.ReadLine());

int[] dizi = new int[elemanSayisi];
int sayac = 0;

for (int i = 0; i < dizi.Length; i++)
{
    Console.WriteLine($" {i + 1}. elemanı giriniz");

    dizi[i] = int.Parse(Console.ReadLine());  
    if (dizi[i] >= 0)
    {
        sayac++;
    }


}



Console.WriteLine($"dizi {sayac} adet pozitif {dizi.Length - sayac} adet negatif sayıdan oluşmaktadir");

Console.ReadLine();

