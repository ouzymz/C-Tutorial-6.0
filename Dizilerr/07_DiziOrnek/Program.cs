/*70.Aşağıdaki Çıktıyı Veren Programın Algoritma ve Akış Diyagramını Çiziniz.Bilgisayar

ilgisayarb
lgisayarbi
gisayarbil
:
:
Bilgisayar

Bilgisayar
ilgisayarb
lgisayarbi
gisayarbil
:
:
Bilgisayar

*/


string str = "Bilgisayar";

char[] kelime = new char[str.Length];

for (int i = 0; i < str.Length; i++)
{
    kelime[i] = str[i];
}

Console.WriteLine(string.Join("", kelime));
for (int sayac = 0; sayac < kelime.Length; sayac++)
{
    string harf = kelime[0];
    for (var sayac2 = 0; sayac2 < kelime.Length - 1; sayac2++)
    {
        kelime[sayac2] = kelime[sayac2 + 1];
    }
    kelime[kelime.Length - 1] = harf;
    Console.WriteLine(string.Join("", kelime));
}

/*
 * string metin = "Bilgisayar";



for (int i = 0; i < metin.Length + 1; i++)
{
    for (int j = 0; j < metin.Length; j++)
    {
        Console.Write(metin[(i + j) % metin.Length]);
    }
    Console.WriteLine();
}

*/