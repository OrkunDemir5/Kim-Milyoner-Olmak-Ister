
int dogruCevap = 0; //doğru cevapları burada topluyoruz.

Console.WriteLine("KİM MİLYONER OLMAK İSTER ? YARIŞMASINA HOŞGELDİNİZ");
Console.WriteLine("1- Kana kırmızı renk veren şey nedir ?");
Console.WriteLine("a) Akyuvar b) Vişne");

string cevap = Console.ReadLine().ToLower();

if (cevap == "b")
{
    Console.WriteLine("Doğru Cevapladınız!!");
    dogruCevap++;
}
else
{
    Console.WriteLine("Maalesef yanlış :( cevap: b) Vişne");
}
Console.WriteLine("2- Türkiye'nin başkenti neresidir");
Console.WriteLine("a) Amasya b) Ankara");

string cevap2 = Console.ReadLine().ToLower();

if (cevap2 == "b")
{
    Console.WriteLine("Doğru Cevapladınız!!");
    dogruCevap++;
}
else
{
    Console.WriteLine("Maalesef yanlış :( cevap: b) Ankara");    
}
if (dogruCevap < 1)
{
    Console.WriteLine("Maalesef 2 soru yanlış bildiniz ve kaybettiniz :(");
}
else
{
    Console.WriteLine("Ay, hangi gezegenin uydusudur?");
    Console.WriteLine("a) Mars b) Dünya");
    string cevap3 = Console.ReadLine().ToLower();

    if (cevap3 == "b")
    {
        Console.WriteLine("Doğru Cevap !!");
        dogruCevap++;
    }
    else
    {
        Console.WriteLine("Maalesef yanlış cevap :( b) Dünya");    
    }
}
// toplam doğru cevap sayısını kontrol etme
if (dogruCevap >= 2)
{
    Console.WriteLine("Tebrikler! Büyük ödülü kazandınız!!");
}
else
{
    Console.WriteLine("Maalesef, büyük ödülü kazanamadınız");
}

