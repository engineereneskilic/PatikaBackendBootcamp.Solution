# Console Application for Basic Programming Tasks

## Table of Contents

- [Introduction](#introduction)
- [Technologies](#technologies)
- [Project Structure](#project-structure)
  - [1. Merhaba Dünyası](#1-merhaba-dünyası)
  - [2. Metin ve Sayısal Değişkenler](#2-metin-ve-sayısal-değişkenler)
  - [3. Rastgele Sayı Üretme](#3-rastgele-sayı-üretme)
  - [4. Rastgele Sayının 3'e Bölümünden Kalan](#4-rastgele-sayının-3e-bölümünden-kalan)
  - [5. Yaş Kontrolü](#5-yaş-kontrolü)
  - [6. Mesajı 10 Kere Yazdırma](#6-mesajı-10-kere-yazdırma)
  - [7. İsimleri Değiştirme](#7-isimleri-değiştirme)
  - [8. BenDeğerDöndürmem Metodu](#8-bendeğerdöndürmem-metodu)
  - [9. İki Sayının Toplamını Döndürme](#9-iki-sayının-toplamını-döndürme)
  - [10. True/False Girişi ile String Döndürme](#10-truefalse-girişi-ile-string-döndürme)
  - [11. En Yaşlı Kişiyi Bulma](#11-en-yaşlı-kişiyi-bulma)
  - [12. En Büyük Sayıyı Bulma](#12-en-büyük-sayıyı-bulma)
  - [13. İsimlerin Yerini Değiştirme](#13-isimlerin-yerini-değiştirme)
  - [14. Sayının Tek mi Çift mi Olduğunu Bulma](#14-sayının-tek-mi-çift-mi-olduğunu-bulma)
  - [15. Gidilen Yolu Hesaplama](#15-gidilen-yolu-hesaplama)
  - [16. Dairenin Alanını Hesaplama](#16-dairenin-alanını-hesaplama)
  - [17. Cümlenin Harf Durumunu Değiştirme](#17-cümlenin-harf-durumunu-değiştirme)
  - [18. Boşlukları Silme](#18-boşlukları-silme)
- [Usage](#usage)
- [License](#license)

## Introduction

This project consists of 18 basic tasks that involve user input, calculations, and string manipulations. Each task demonstrates simple programming concepts using C#.

## Technologies

- C# 10
- .NET Core 6.0

## Project Structure

### 1. Merhaba Dünyası

**Proje Açıklaması:**  
Ekrana "Merhaba", "Nasılsın?", "İyiyim", ve "Sen nasılsın?" mesajları sırasıyla yazdırılır.

```csharp
// Konsola sabit mesajlar yazdırılır.
Console.WriteLine("Merhaba");
Console.WriteLine("Nasılsın?");
Console.WriteLine("İyiyim");
Console.WriteLine("Sen nasılsın?");
``````
**Kod Açıklaması:**  Console.WriteLine() metodu kullanılarak ekrana dört farklı mesaj yazdırılır.

### 2. Metin ve Sayısal Değişkenler

**Proje Açıklaması:**  
Bir metinsel ve bir sayısal veri tipi tanımlanır. Bu değerler ekrana yazdırılır.

```csharp
Metinsel ve sayısal veri tipleri tanımlanır ve ekrana yazdırılır.
string isim = "Ali";
int yas = 30;
Console.WriteLine("İsim: " + isim + ", Yaş: " + yas);
``````
**Kod Açıklaması:** Bir string ve bir int değişkeni tanımlanır, ardından bu değişkenler Console.WriteLine() ile ekrana yazdırılır.


### 3. Rastgele Sayı Üretme

**Proje Açıklaması:**  
1 ile 100 arasında rastgele bir sayı üretilir ve bu sayı ekrana yazdırılır.


```csharp
//Rastgele bir sayı üretilir ve ekrana yazdırılır.
Random rastgele = new Random();
int sayi = rastgele.Next(1, 101);
Console.WriteLine("Rastgele Sayı: " + sayi);
``````
**Kod Açıklaması:** Random sınıfı kullanılarak 1 ile 100 arasında rastgele bir sayı üretilir ve bu sayı ekrana yazdırılır.


### 4. Rastgele Sayının 3'e Bölümünden Kalan

**Proje Açıklaması:**  Üretilen rastgele sayının 3’e bölümünden kalan hesaplanır ve ekrana yazdırılır.

```csharp
Rastgele üretilen sayının 3'e bölümünden kalan hesaplanır ve yazdırılır.
int kalan = sayi % 3;
Console.WriteLine("3'e bölümünden kalan: " + kalan);
``````
**Kod Açıklaması:** Bu kodda % operatörü kullanılarak rastgele üretilen sayının 3’e bölümünden kalan hesaplanır.



### 5. Yaş Kontrolü

**Proje Açıklaması:**  Kullanıcıdan alınan yaş 18’den büyükse "+" değilse "-" işareti ekrana yazdırılır.

```csharp
Kullanıcıdan yaş bilgisi alınır ve kontrol yapılır.
int kullaniciYasi = 20; // Varsayılan yaş değeri.
if (kullaniciYasi > 18)
{
    Console.WriteLine("+");
}
else
{
    Console.WriteLine("-");
}
``````
**Kod Açıklaması:** if yapısı kullanılarak yaş kontrolü yapılır. Eğer yaş 18'den büyükse "+" işareti ekrana yazdırılır.


### 6. Mesajı 10 Kere Yazdırma

**Proje Açıklaması:**  Ekrana 10 defa "Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem." mesajı yazdırılır.

```csharp
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem.");
}
``````
**Kod Açıklaması:** for döngüsü kullanılarak mesaj 10 kez ekrana yazdırılır.


### 7. İsimleri Değiştirme

**Proje Açıklaması:**  Kullanıcıdan iki metinsel değer alınır ve bu isimlerin yerleri değiştirilir.


```csharp
//İki isim değişkeni tanımlanır ve yerleri değiştirilir.
string isim1 = "Gülse Birsel";
string isim2 = "Demet Evgar";
string gecici = isim1;
isim1 = isim2;
isim2 = gecici;
Console.WriteLine("İsim 1: " + isim1);
Console.WriteLine("İsim 2: " + isim2);
``````
**Kod Açıklaması:** Üçüncü bir geçici değişken yardımıyla iki string değişkenin değerleri yer değiştirilir.


### 8. BenDeğerDöndürmem Metodu

**Proje Açıklaması:**  Değer döndürmeyen bir metot tanımlanır. Bu metot ekrana sabit bir mesaj yazdırır.

```csharp
// Değer döndürmeyen bir metot tanımlanır.
void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma.");
}
BenDegerDondurmem();
``````
**Kod Açıklaması:** Bu metodun geri dönüş tipi void olarak tanımlanmıştır ve ekrana sabit bir mesaj yazdırır.


### 9. İki Sayının Toplamını Döndürme

**Proje Açıklaması:**  İki sayı alıp bu sayıların toplamını döndüren bir metot yazılır.

```csharp
// İki sayının toplamını döndüren bir metot tanımlanır.
int Topla(int sayi1, int sayi2)
{
    return sayi1 + sayi2;
}
Console.WriteLine("Toplam: " + Topla(5, 10));
``````
**Kod Açıklaması:** Bu metot iki sayıyı alır ve toplamlarını geri döndürür.



### 10. True/False Girişi ile String Döndürme

**Proje Açıklaması:**  Kullanıcıdan true ya da false değeri alınarak string dönen bir metot yazılır.

```csharp
// Kullanıcıdan true/false alıp string dönen metot.
string TrueFalseStringDondur(bool deger)
{
    if (deger)
    {
        return "Doğru";
    }
    return "Yanlış";
}
Console.WriteLine(TrueFalseStringDondur(true));
``````
**Kod Açıklaması:** if yapısı kullanılarak gelen bool değere göre "Doğru" veya "Yanlış" string’i döndürülür.


### 11. En Yaşlı Kişiyi Bulma

**Proje Açıklaması:**  Üç kişiden en yaşlı olanı bulan bir metot yazılır.

```csharp
// Üç kişinin yaşını karşılaştırarak en yaşlıyı bulan metot.
string EnYasliKisiyiBul(int yas1, int yas2, int yas3)
{
    if (yas1 > yas2 && yas1 > yas3)
    {
        return "Birinci kişi en yaşlı.";
    }
    else if (yas2 > yas3)
    {
        return "İkinci kişi en yaşlı.";
    }
    return "Üçüncü kişi en yaşlı.";
}
Console.WriteLine(EnYasliKisiyiBul(45, 50, 40));
``````
**Kod Açıklaması:** Üç yaş karşılaştırılarak en yaşlı kişi belirlenir ve uygun mesaj geri döndürülür.


### 12. En Büyük Sayıyı Bulma

**Proje Açıklaması:**  Verilen sayılardan en büyüğünü bulan bir metot yazılır.
```csharp
// Verilen sayılar arasından en büyük olanı bulur.
int EnBuyukSayi(int[] sayilar)
{
    int enBuyuk = sayilar[0];
    foreach (int sayi in sayilar)
    {
        if (sayi > enBuyuk)
        {
            enBuyuk = sayi;
        }
    }
    return enBuyuk;
}
int[] sayiDizisi = { 5, 9, 15, 2, 8 };
Console.WriteLine("En büyük sayı: " + EnBuyukSayi(sayiDizisi));
``````
**Kod Açıklaması:** Döngü yardımıyla bir sayı dizisi içindeki en büyük sayı bulunur ve geri döndürülür.


### 13. İsimlerin Yerini Değiştirme

**Proje Açıklaması:**  Bir metin dizisindeki isimlerin yerleri değiştirilir.

```csharp
// İsimlerin yerlerini değiştiren bir algoritma.
string[] isimler = { "Ahmet", "Mehmet", "Ayşe" };
string temp = isimler[0];
isimler[0] = isimler[1];
isimler[1] = temp;
Console.WriteLine("Yeni isim sırası: " + string.Join(", ", isimler));
``````
**Kod Açıklaması:** Dizinin ilk iki elemanının yerleri değiştirilir ve string.Join() ile ekrana yazdırılır.


### 14. Sayının Tek mi Çift mi Olduğunu Bulma

**Proje Açıklaması:**  Verilen sayının tek mi çift mi olduğunu bulan bir metot yazılır.

```csharp
// Verilen sayının tek mi çift mi olduğunu bulan metot.
string TekMiCiftMi(int sayi)
{
    if (sayi % 2 == 0)
    {
        return "Çift";
    }
    return "Tek";
}
Console.WriteLine(TekMiCiftMi(9));
``````
**Kod Açıklaması:** Girilen sayının çift olup olmadığı % operatörü ile kontrol edilir.


### 15. Gidilen Yolu Hesaplama

**Proje Açıklaması:**  Girilen hız ve süre bilgilerine göre gidilen mesafeyi hesaplayan bir metot yazılır.

```csharp
// Hız ve süre bilgisi ile mesafe hesaplama.
double MesafeHesapla(double hiz, double sure)
{
    return hiz * sure;
}
Console.WriteLine("Gidilen Mesafe: " + MesafeHesapla(80, 2.5) + " km");
``````
**Kod Açıklaması:** Verilen hız ve süre çarpılarak gidilen mesafe hesaplanır.

### 16. Dairenin Alanını Hesaplama

**Proje Açıklaması:**  Girilen yarıçap değerine göre dairenin alanını hesaplayan bir metot yazılır.

```csharp
// Dairenin alanını hesaplayan metot.
double DaireninAlani(double yaricap)
{
    return Math.PI * yaricap * yaricap;
}
Console.WriteLine("Dairenin Alanı: " + DaireninAlani(5) + " m²");
``````
**Kod Açıklaması:** Yarıçap değeri kullanılarak Math.PI ile dairenin alanı hesaplanır.


### 17. Cümlenin Harf Durumunu Değiştirme

**Proje Açıklaması:**  Verilen bir cümledeki büyük harfleri küçük, küçük harfleri büyük harfe çeviren bir metot yazılır.

```csharp
// Harflerin durumunu değiştiren metot.
string HarfDurumunuDegistir(string cumle)
{
    char[] karakterler = cumle.ToCharArray();
    for (int i = 0; i < karakterler.Length; i++)
    {
        if (char.IsUpper(karakterler[i]))
        {
            karakterler[i] = char.ToLower(karakterler[i]);
        }
        else if (char.IsLower(karakterler[i]))
        {
            karakterler[i] = char.ToUpper(karakterler[i]);
        }
    }
    return new string(karakterler);
}
Console.WriteLine(HarfDurumunuDegistir("Merhaba Dünya!"));
``````
**Kod Açıklaması:** Her karakterin harf durumu kontrol edilerek, büyük harfler küçüğe, küçük harfler büyüğe çevrilir.

### 18. Boşlukları Silme

**Proje Açıklaması:**  Verilen bir metindeki boşlukları silen bir metot yazılır.

```csharp
string BosluklariSil(string metin)
{
    return metin.Replace(" ", "");
}
Console.WriteLine(BosluklariSil("Merhaba Dünya"));
``````
**Kod Açıklaması:** Replace() metodu kullanılarak tüm boşluk karakterleri metinden çıkarılır.

## Usage

To execute any of the tasks, simply run the console application. The code structure allows each task to be executed independently.

## License

Bu proje MIT lisansı altında lisanslanmıştır. Kullanım ve dağıtım serbesttir.
