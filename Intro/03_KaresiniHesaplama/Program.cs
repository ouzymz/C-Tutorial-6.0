
using System.Data.SqlTypes;

Console.Write("Lütfen karesini hesaplamak istediğiniz bir tam sayı giriniz");

double sayi = Convert.ToDouble(Console.ReadLine()), karesi, ustu;



/* ReadLine okunan değeri integer olarak geri döndürür. Sayı üzerinde işlem yapabilmemiz için integer'a çevirmem gerekiyor. Convert.ToInt32 
 ile sayiyi int'a çevirde ve integer olduğunu tanımladık.
 */
ustu = 2;
karesi = Math.Pow(sayi,ustu);

Console.WriteLine("Girdiğiniz sayının karesi: " + karesi);
// C# case sensitive bir dildir, yani büyük küçük harf önemli. 

Console.ReadLine();


