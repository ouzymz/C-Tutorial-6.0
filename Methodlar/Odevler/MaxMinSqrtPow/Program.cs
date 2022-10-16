

double mypow(double sayi, double ussu)
{

    if (ussu > 0)
    {
        for (int i = 1; i < ussu; i++)
        {
            sayi *= sayi;
        }
    }
    if (ussu <= 0)
    {
        for (int i = 0; i >= ussu; i--)
        {
            int sayi1 = (int)sayi;

            sayi = (double)sayi / (double)sayi1;
        }
    }

    return sayi;
}

Console.WriteLine(mypow(16.0, 2.0));

int a = 20;
decimal y /= (decimal)a;
y /= (decimal)a;  


int[] inputs = new int[10];

inputs[0] = 100;
inputs[1] = 20;
inputs[2] = 30;
inputs[3] = 2;
inputs[4] = -1;
inputs[5] = 50;
inputs[6] = 13;
inputs[7] = 23;
inputs[8] = 151;
inputs[9] = 42;

int MyMin(int[] inputs)
{
    int minValue = int.MaxValue;

    for (int i = 0; i < inputs.Length; i++)
    {
        if (inputs[i] < minValue)
            minValue = inputs[i];
    }
    return minValue;

}

int MyMax(int[] inputs)
{
    int maxValue = int.MinValue;

    for (int i = 0; i < inputs.Length; i++)
    {
        if (inputs[i] > maxValue)
            maxValue = inputs[i];
    }
    return maxValue;

}

Console.WriteLine(MyMin(inputs));
Console.WriteLine(MyMax(inputs));

double MySqrt(double input)
{
 return Math.Pow(input, 0.5);
}

Console.WriteLine(MySqrt(16));

Console.ReadLine();

