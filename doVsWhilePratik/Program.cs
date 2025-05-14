Console.Write("Limit değerini giriniz: "); 
int limit = Convert.ToInt32(Console.ReadLine());

int sayac = 0; // başlangıç olduğu için 0 alıyoruz.

while (sayac < limit) //başlangıcı 0 aldığımız için sayacın limitten yalnızca küçük olduğu senaryoyu alıyoruz.
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac++; //sonsuz bir döngüde kalmaması için sayacı artırıyoruz ve limit değerine ulaştığında çıkmasını sağlıyoruz.
}

//while'da eğer 0'dan büyük değerler girersek koşul sağlanacak ve girdiğimiz değer kadar tanımladığımız yazı yazdırılacak.
// Eğer limit'i -1 girersek sayac'tan küçük olacağı için koşul sağlanmayacak.



Console.Write("Limit değerini giriniz: ");
int limit1 = Convert.ToInt32(Console.ReadLine());

int sayac1 = 0; //başlangıç olarak 0 aldık.

do
{
    Console.WriteLine("Ben bir Patika'lıyım"); //girdiğimiz limit değeri kadar sayıyı yazdıracak.
    sayac1++; // sonsuz bir  döngüde kalmaması için limit değeri kadar sayacı artırıyor.
} while (sayac1 < limit1); // eğer sayacın limitten küçük olduğu bir durum varsa yani koşul sağlanmasa da bir kere metni yazdırıyor.


// FARK:
// while döngüsünde koşul en başta kontrol edilir. Eğer limit -5 gibi bir negatif sayıysa, döngüye hiç girilmez.
// do-while döngüsünde ise döngü en az 1 kez çalışır çünkü koşul sona bırakılmıştır.
// Örneğin limit = -5 verilirse:
//   while → hiç yazdırmaz.
//   do-while → 1 kez "Ben bir Patika'lıyım" yazar.
