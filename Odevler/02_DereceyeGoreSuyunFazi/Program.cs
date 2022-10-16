Console.Write("Suyun derecesinizi giriniz");

Double derece = Convert.ToInt32(Console.ReadLine());

if (derece >= 100)
{
	Console.WriteLine("Su gaz fazındadır");
}
else if (derece >= 0)
{
	Console.WriteLine("Su sıvı fazındadır");
}
else
{
	Console.WriteLine("Su katı fazındadır");
}

Console.ReadLine();