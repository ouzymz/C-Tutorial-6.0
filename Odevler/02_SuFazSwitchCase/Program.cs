// Switch case if else göre daha hızlı çalışır.
// ctrl + "k" + "c"

Console.Write("Suyun derecesinizi giriniz");

Double derece = Convert.ToInt32(Console.ReadLine());

switch (derece)
	{
		case 0 : Console.Write("Su Katı veya sıvı fazdadir.");
		
			 break;

		case < 0 :	Console.Write("Su katı fazdadir");
		
			 break;

		case > 100 :	Console.Write("Su gaz fazdadir");
		
			 break;

		case  100 :	Console.Write("Su Sıvı yada gaz fazdadir");
		
			 break;

		default:	Console.Write("Su Sıvı yada gaz fazdadir");
							
			 break;
	}

Console.ReadLine();		