Console.Write("faktöriyelini almak istediğiniz sayıyı giriniz");

int sayi1 = Convert.ToInt32(Console.ReadLine());

int faktoriyel = 1;

if (sayi1==0)
{
    faktoriyel = 1;
}

for (int i = 1;  i <= sayi1 ; i++)
{
    faktoriyel = faktoriyel * i;
}

Console.WriteLine("Girdiğiniz sayının faktöriyel sonucu {0}'dir.", faktoriyel);

Console.ReadLine();
