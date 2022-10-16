/*.
10 elemanlı bir dizinin elemanlarından hem 4'e hemde 5'e bölünen
sayıları bulan programın algoritma ve akış diyagramı çiziniz
*/

int[] sayi = new int[5];

for (int i = 0; i < sayi.Length; i++)
{
    Console.WriteLine($" {i + 1}. Sayı Giriniz :");
    sayi[i] = int.Parse(Console.ReadLine());
}
int sayac = 0;
foreach (var item in sayi)
{
    if (item % 20 == 0)
    {
        sayac++;
    }
}

Console.WriteLine("Hem 4 Hem 5'e Bölünen sayıların adeti :" + sayac);