# Rüya Manavı Uygulaması

Bu C# uygulaması, kullanıcıya çeşitli meyve fiyatlarını gösterir ve seçilen meyveye göre fiyat hesaplaması yapar. Uygulama, `if-else` ve `switch-case` yapılarını kullanarak farklı meyve seçimlerine göre fiyat belirler.

## Table of Contents

- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Usage](#usage)
- [License](#license)

## Introduction

Bu program, bir manav uygulaması simülasyonudur. Kullanıcıdan hangi meyveyi satın almak istediği sorulur ve seçilen meyveye göre uygun fiyat ekrana yazdırılır. Meyve fiyatları sabittir ve belirlenen meyveye göre kullanıcıya gösterilir.

## Technologies

- **C# 10.0** veya daha üstü
- **.NET 6.0 SDK** veya daha üstü

## Code Overview

### 1. Kullanıcıyı Karşılama ve Meyve Fiyatlarını Gösterme

```csharp
Console.WriteLine("Rüya Manavına Hoş Geldiniz!");
Console.WriteLine("Elma=25 TL");
Console.WriteLine("Armut=35 TL");
Console.WriteLine("Çilek=25 TL");
Console.WriteLine("Muz=35 TL");
Console.WriteLine("Diğer bütün meyveler=4 TL");
```

- **Explanation**: Kullanıcıya manava hoş geldiniz mesajı verilir ve mevcut meyvelerin fiyatları ekranda gösterilir.

### 2. Kullanıcıdan Meyve Seçimi Alma ve Fiyat Atama (`if-else` Yapısı)

```csharp
Console.Write("Hangi meyveyi almak istersiniz? (Elma/Armut/Çilek/Muz/Diger): ");
string meyve = Console.ReadLine().ToLower();
decimal fiyat = 0;

if (meyve == "elma")
{
    fiyat = 25;
}
else if (meyve == "armut")
{
    fiyat = 35;
}
else if (meyve == "çilek")
{
    fiyat = 25;
}
else if (meyve == "muz")
{
    fiyat = 35;
}
else
{
    fiyat = 4;
}
```

- **Explanation**: Kullanıcıdan meyve seçimi istenir ve `if-else` yapısı ile kullanıcının girdiği meyveye göre uygun fiyat atanır. `ToLower()` fonksiyonu kullanılarak büyük/küçük harf farkı ortadan kaldırılır.

### 3. Kullanıcıdan Meyve Seçimi Alma ve Fiyat Atama (`switch-case` Yapısı)

```csharp
string meyve_ = Console.ReadLine().ToLower();
decimal fiyat_ = 0;

switch (meyve_)
{
    case "elma":
        fiyat_ = 25;
        break;
    case "armut":
        fiyat_ = 35;
        break;
    case "çilek":
        fiyat_ = 25;
        break;
    case "muz":
        fiyat_ = 35;
        break;
    default:
        fiyat_ = 4;
        break;
}
```

- **Explanation**: Kullanıcının girdiği meyveye göre `switch-case` yapısı ile fiyat belirlenir. Burada her bir meyve için farklı fiyatlar atanırken, yukarıdaki meyvelerden farklı bir giriş yapılması durumunda varsayılan olarak 4 TL atanır.

### 4. Fiyat Bilgisinin Ekrana Yazdırılması

```csharp
Console.WriteLine($"Seçtiğiniz meyve: {meyve}, Fiyatı: {fiyat} TL");
Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {fiyat_} TL");
```

- **Explanation**: Kullanıcının seçtiği meyve ve bu meyvenin fiyatı ekrana yazdırılır. String interpolation (`$`) kullanılarak fiyat bilgisi direkt metin içinde gösterilir.

### Notlar

- **String Interpolation**: `$` işareti, değişkenleri string içinde daha kolay göstermek için kullanılır. Örneğin: `$"{fiyat}"`.
- **Switch-Case Yapısı**: Bu yapı, birden fazla olası durumu ele almak için kullanılır. Farklı meyve seçeneklerine göre farklı fiyatlar atanır.

## Usage

1. Bu kodu bir C# dosyasına (örneğin `Program.cs`) kopyalayın.
2. Terminalde proje klasörüne gidin.
3. Kodu çalıştırmak için şu komutu kullanın:
    ```bash
    dotnet run
    ```
4. Kullanıcıya sunulan meyvelerden birini seçin ve fiyat bilgisini görün.

## License

Bu proje MIT lisansı altında lisanslanmıştır. Kullanım ve dağıtım serbesttir.
