/*
 * Bir sınıftaki 10 öğrencinin bir dersten aldıkları yıl sonu notları veriliyor.
 * Başarı notu 50 olduğuna göre kaç öğrencinin başarılı olduğunu bulan programın algoritma ve 
 * akış diyagramınıçiziniz.
 */


int[] dersNotlari = new int[10];
int sayac = 0;


for (int i = 0; i < dersNotlari.Length; i++)
{
    Console.WriteLine($" {i + 1}. ogrencinin notunu giriniz");

    dersNotlari[i] = int.Parse(Console.ReadLine());
    if (dersNotlari[i] >= 50)
    {
        sayac++;
    }
}

Console.WriteLine($"{sayac} kisi dersten 50 ve üzeri not alarak basarili olmustur");

Console.ReadLine();

