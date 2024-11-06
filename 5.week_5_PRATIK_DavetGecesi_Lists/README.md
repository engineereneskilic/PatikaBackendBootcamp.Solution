
# Patika Plus Gala Gecesi Ziyaretçi Listesi

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Explanation](#explanation)
  - [Liste Tanımlama](#liste-tanımlama)
  - [Döngü ile Listeyi Yazdırma](#döngü-ile-listeyi-yazdırma)
- [Usage](#usage)
- [Output](#output)
- [License](#license)

## Introduction

Bu proje, Patika Plus Gala Gecesi'ne davetli olan kişilerin isimlerini bir liste halinde yönetmeyi ve bu listeyi konsola yazdırmayı amaçlayan bir konsol uygulamasıdır. Projede, `List<T>` koleksiyon yapısı ile veriler saklanır ve `foreach` döngüsü kullanılarak ekrana yazdırılır.

## Technologies

- **Dil**: C#
- **Geliştirme Ortamı**: .NET Core SDK
- **Konseptler**: Liste Yapıları, Döngüler

## Code Overview

### Sınıflar ve Metodlar

#### Program Sınıfı
`Program` sınıfı, `Main` metodunu içerir ve uygulamanın ana akışını yönetir.

- **`List<string> guestList`**: Galaya davet edilen kişilerin isimlerini içeren bir liste.
- **`foreach` döngüsü**: Listeyi döngü kullanarak ekrana yazdırmak için kullanılır.

## Explanation

### Liste Tanımlama

```csharp
List<string> guestList = new List<string>
{
    "Bülent Ersoy",
    "Ajda Pekkan",
    "Ebru Gündeş",
    "Hadise",
    "Hande Yener",
    "Tarkan",
    "Funda Arar",
    "Demet Akalın"
};
```

- **guestList**: Gala gecesine katılacak kişilerin isimlerinin bulunduğu `List<string>` türünde bir liste.
- Bu listeye doğrudan `string` türünde isimler eklenmiştir.

### Döngü ile Listeyi Yazdırma

```csharp
foreach (string guest in guestList)
{
    Console.WriteLine("- " + guest);
}
```

- **`foreach` döngüsü**: `guestList` içerisindeki her bir `guest` elemanını tek tek ekrana yazdırır.
- Her bir ismin önüne `"- "` ekleyerek çıktıyı daha düzenli bir hale getirir.

## Usage

1. Uygulama çalıştırıldığında, `guestList` listesinde yer alan isimler otomatik olarak ekrana yazdırılır.
2. Konsolda tüm davetlilerin isimleri sıralanarak gösterilir.

### Programı Çalıştırmak İçin

1. Projeyi bir .NET Core ortamında açın.
2. `Program.cs` dosyasını çalıştırın.
3. Konsol ekranında davetlilerin isimlerini görüntüleyin.

## Output

Örnek bir çıktı aşağıdaki gibidir:

```plaintext
Patika Plus Gala Gecesi Ziyaretçi Listesi:
- Bülent Ersoy
- Ajda Pekkan
- Ebru Gündeş
- Hadise
- Hande Yener
- Tarkan
- Funda Arar
- Demet Akalın
```

## License

This project is licensed under the MIT License.
