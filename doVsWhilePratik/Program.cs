/*Console.Write("Limit değerini giriniz: "); 
int limit = Convert.ToInt32(Console.ReadLine());

int sayac = 0;

while (sayac < limit)
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac++;
}*/

Console.Write("Limit değerini giriniz: ");
int limit = Convert.ToInt32(Console.ReadLine());

int sayac = 0;

do
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac++;
} while (sayac < limit);

// FARK:
// while döngüsünde koşul en başta kontrol edilir. Eğer limit -5 gibi bir negatif sayıysa, döngüye hiç girilmez.
// do-while döngüsünde ise döngü en az 1 kez çalışır çünkü koşul sona bırakılmıştır.
// Örneğin limit = -5 verilirse:
//   while → hiç yazdırmaz.
//   do-while → 1 kez "Ben bir Patika'lıyım" yazar.
