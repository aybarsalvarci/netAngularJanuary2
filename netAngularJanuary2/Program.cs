
/*
 * 
 * 1 - C# veri tipleri
 * 
 * byte | 1 byte uzunluk | 0  255 arası değer alır
 * sbyte| 1 byte uzunluk | -128  127
 * short| 2 byte uzunluk |-32768 32767 arası değer alır
 * ushort | 2 byte uzunluk | 0 65535 arası değer alır
 * int | 4 byte uzunluk |-2.147.483.648 2.124.483.648 arası değer alır
 * uint | 4 byte uzunluk |0 4.294.967.295 arası değer alır 
 * long | 8 byte uzunluk | -10^20 10^20 arası değer alır 
 * ulong | 8 byte | 0  2X10^20 arası değer alır
 * float | 4 byte |1.5x 10^-45 3.4x10^38 arası değer alır.
 * double | 8 byte | 5.0x10^-324 1.7x10^308 arası değer alır.
 * decimal|12 byte | -1.0^10-28 7.9x10^28 arası değer alır.
 * char | 2byte | tüm unicode değerleri alır
 * string | Tek bir karakter, sözcük veya cümle saklanır.
 * boolean | true - false değerleri alır
 * 
 * 2 - değişkenlerin bellek tüketimini karşılaştırın.
 */
int x = 5;  // 4 byte ram tüketir
double y = 5.2; //  8 byte ram tüketir
string name = "Mehmet"; // her karakter 2 byte toplamda 12 byte veri tüketir

// 3 - Kullancıdan girilen iki sayının toplamı.
Console.Write("Bir sayı girin: ");
int? num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci bir sayı girin: ");
int? num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num1 + num2);