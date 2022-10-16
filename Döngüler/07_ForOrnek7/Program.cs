int fibonacci1 = 1, fibonacci2 = 1;


for (int i = 0; i < 5; i++)
{

    Console.WriteLine(fibonacci2 + "\n");
    Console.WriteLine(fibonacci1 + "\n");
    

    fibonacci2 += fibonacci1;
    fibonacci1 += fibonacci2;

}

Console.ReadLine();