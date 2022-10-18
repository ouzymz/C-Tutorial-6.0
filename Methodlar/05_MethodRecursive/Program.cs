
//Method ile loop oluşturma gibi düşünebilirsin.

 static int factorial(int n)
{
    if (n == 0)
    {
        return 1;
    }
    int recurse = factorial(n - 1);
    int result = n * recurse;
    return result;
}

void DisplayBinary(int value)
{
    if (value > 0)
    {
        DisplayBinary(value / 2);
        Console.WriteLine(value % 2); 
    }
}


DisplayBinary(50);

/*
  50        0
        25        1
             12        0
                   6        0
                         3        1
                               1        1
                                    */



void SayiyiYazdir(int input)
{
    for (int i = 1; i <= input; i++)
    {
        Console.WriteLine(i);
    }
}

SayiyiYazdir(5);

int SayiAlma()
{
    int sayi = Convert.ToInt32(Console.ReadLine());
    return sayi;
}

int DahaKucuk(int input1, int input2)
{
    if (input1 < input2)
        return input1;
    else
        return input2;
}

int KucukDeger(int input1, int input2, int input3)
{
    return DahaKucuk(DahaKucuk(input1, input2), input3);
}

Console.WriteLine(KucukDeger(SayiAlma(), SayiAlma(), SayiAlma()));

Console.ReadLine();