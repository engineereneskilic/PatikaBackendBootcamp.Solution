using _7.week_SALI_DataLIB;
using System;
using System.Linq;
using System.Security;

Console.WriteLine("ÜLKE ÜLKE ÜNLÜLER (+ÜLKE ADLARI DAHİL)");

var unluler = Veri.unluler;
var ulkeler = Veri.ulkeler;

var sonuc = ulkeler.GroupJoin(
    unluler,
    ulke => ulke.Id,
    unlu => unlu.UlkeId,
    (ulke, unluler) => new
    {
        UlkeId = ulke.Id,
        UlkeAd = ulke.Ad,
        Unluler = unluler.ToList()
    }
    );

foreach (var ulke in sonuc)
{
    Console.WriteLine(ulke.UlkeAd + " (" + ulke.UlkeId + ")");

    foreach (Unlu unlu in ulke.Unluler)
    {
        Console.WriteLine(" - " + unlu.Ad + " (" + unlu.DogumYili + ")");
    }
}

Console.ReadKey();
