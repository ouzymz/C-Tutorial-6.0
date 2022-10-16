// Değişken : içerisinde değer tuttuğumuz yağıdır.
//Veri Tipi : içeride tutlan değere göre deü,ilenin veri tipini belirlipruz.
/*
 * byte : 1 byte = 1*8 = 8 --> 2 üstü 8
 * short : 2 byte = 2*8 = 16 --> 2 üstü 16
 * int : 4 byte = 4*8 = 32 --> 2 üstü 32
 * 
 * 
 */

using System.Diagnostics.Metrics;

sbyte plakaNo = -128; // [-128,127]
byte plakaNo2 = 255; // [0,255]


//F12 ile classın barındırdığı öetodları inceleyebilirsin. 

Console.WriteLine(17); // Tamsayılar int olarak algılanır
Console.WriteLine(17.6);  // Ondalık sayılar harfsiz yazılırsa double olarak algılanır
Console.WriteLine(17.3d); // // Ondalık sayılar harfsiz yazılırsa double olarak algılanır
Console.WriteLine(17.3f); // F girilirse fload olarak algılanır
Console.WriteLine(173M); // M girilirse decimal olarak algılanır


