int fibonacci1 = 1, fibonacci2 = 1, sayac = 0;

baslangic:

if (sayac < 5)
{
    Console.WriteLine(fibonacci2 + "\n");
    Console.WriteLine(fibonacci1 + "\n");
    

    fibonacci2 += fibonacci1;
    fibonacci1 += fibonacci2;

    sayac++;
    goto baslangic;

}


Console.ReadLine();





