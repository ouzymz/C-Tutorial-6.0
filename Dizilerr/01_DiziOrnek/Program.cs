
//62.10 elemanlı bir sayı dizisini girişini yapan algoritma ve akış diyagramını çiziniz.


int[] elemanlar = new int[10];


for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"lütfen {i + 1}. elemanı giriniz");

    elemanlar[i] = Convert.ToInt32(Console.ReadLine());

}


Array.Sort(elemanlar);

for (int i = 0; i < elemanlar.Length; i++)
{
    Console.WriteLine(elemanlar[i]);
}

Console.ReadLine();