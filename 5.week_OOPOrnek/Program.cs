using OOPOrnek;

Console.WriteLine("------------ HAYVANLARI OLUŞTURUYORUZ ------------");

Kedi kedi1 = new Kedi();
Console.WriteLine(kedi1);

Serce serce1 = new Serce();
Console.WriteLine(serce1);

Tavuk tavuk1 = new Tavuk();
Console.WriteLine(tavuk1);

Console.WriteLine("\r\n--------- HAYVANLAR SESLERİNİ ÇIKARIYOR ----------");
// SESLERİ ÇIKARTALIM
kedi1.SesCikar();
serce1.SesCikar();
tavuk1.SesCikar();

Console.WriteLine("\r\n----------- YENİ ARABA OLUŞTURUYORUZ ------------");
Araba a1 = new Araba();
Console.WriteLine("Aracın adı: " + a1.Ad);

Console.WriteLine("\r\n----------- YENİ UÇAK OLUŞTURUYORUZ ------------");
Ucak ucak1 = new Ucak();
// Console.WriteLine("Aracın adı: " + ucak1.Ad);

Console.WriteLine("\r\n-------------- TOPLU İŞLEMLER -------------------");

Console.WriteLine("------------ TÜM HAYVANLAR BESLENSİN ------------");
Hayvan[] hayvanlar = { kedi1, serce1, tavuk1 };

foreach (Hayvan hayvan in hayvanlar)
{
    Console.Write("{0,-15}: ", hayvan.Tur);
    hayvan.Beslen();
}

List<Arac> araclar = new List<Arac>() { a1, ucak1 };

Console.WriteLine("\r\n------------------ ARAÇLAR ------------------");

foreach (Arac a in araclar)
{
    Console.WriteLine(a.Ad + " adlı araç " + a.HareketSahasi.ToLower() + "da ilerliyor.");
}

Console.WriteLine("\r\n------------------ UÇABİLENLER ------------------");
IUcabilen u1 = ucak1;
IUcabilen u2 = serce1;
List<IUcabilen> list = new List<IUcabilen>() { u1, u2 };

foreach (IUcabilen u in list)
    u.Uc();

Console.WriteLine("\r\n------------------ TÜM NESNELERDEN UÇANLARI UÇUR ------------------");
object[] tumNesneler = { kedi1, serce1, tavuk1, a1, ucak1 };

// BU NESNELERİ DÖNGÜYLE DÖNERKEN SADECE UÇABİLENLERİ UÇUR
foreach (object o in tumNesneler)
{
    if (o is IUcabilen)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        ((IUcabilen)o).Uc();  
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(o + " UÇAMAZ!!");
    }
}


Console.ReadKey();


Console.Clear();