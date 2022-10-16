

string sifre = "asdasd123";

Console.WriteLine("sifreyi giriniz");

string denemeSifre;


int denemeSayisi = 0;
do
{

    denemeSifre = Console.ReadLine();
    denemeSayisi ++;
    if (denemeSifre == sifre)
    {
        Console.WriteLine($"{denemeSayisi}. adımda bildiniz. Giriş yapılıyor");
        break;
    }
    


} while (denemeSayisi != 3);


if (denemeSifre != sifre)
	{
        Console.WriteLine("Hesabınız Kitlenmistir!!");
	}

Console.ReadLine();

