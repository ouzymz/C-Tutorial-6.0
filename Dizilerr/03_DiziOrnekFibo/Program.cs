int fibonacci1 = 1, fibonacci2 = 1, sayac = 0;


int[] dizi = new int[10];

for (int i = 0; i < 10; i+=2)
{

    dizi[i] = fibonacci2;
    dizi[i + 1] = fibonacci1;


    fibonacci2 += fibonacci1;
    fibonacci1 += fibonacci2;

}


foreach (var item in dizi)
{
    Console.WriteLine($"{item}\n");
}









