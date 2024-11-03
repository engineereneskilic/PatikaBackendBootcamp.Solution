
# TechStore Ürün Yönetim Sistemi

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
  - [Sınıflar](#sınıflar)
  - [Telefon](#telefon)
  - [Bilgisayar](#bilgisayar)
- [Explanation](#explanation)
  - [Encapsulation](#encapsulation)
  - [Inheritance](#inheritance)
  - [Polymorphism](#polymorphism)
  - [Abstraction](#abstraction)
- [Usage](#usage)
- [Output](#output)
- [License](#license)

---

## Introduction

Bu proje, bir teknoloji mağazasında Telefon ve Bilgisayar gibi ürünlerin yönetimi için geliştirilmiş bir konsol uygulamasıdır. Uygulama, `Inheritance`, `Encapsulation`, `Polymorphism`, ve `Abstraction` gibi nesne yönelimli programlama prensiplerini kullanarak, kullanıcıdan alınan verilere göre ürün oluşturulmasını sağlar ve detaylarını konsol ekranında gösterir.

## Technologies

- **Dil**: C#
- **Geliştirme Ortamı**: .NET Core SDK
- **Konseptler**: Nesne Yönelimli Programlama (OOP), Kalıtım, Çok Biçimlilik, Kapsülleme, Soyutlama

## Code Overview

### Sınıflar

#### BaseMakine
`BaseMakine` sınıfı, `Telefon` ve `Bilgisayar` sınıfları için temel özellikleri ve metodları içeren soyut bir sınıftır.

- **Özellikler**:
  - `ProductionDate`: Üretim tarihini otomatik olarak belirler.
  - `SerialNumber`: Ürün seri numarası.
  - `Name`: Ürün adı.
  - `Description`: Ürün açıklaması.
  - `OperatingSystem`: İşletim sistemi.
- **Metotlar**:
  - `abstract GetProductName()`: Ürün adını getirir, `Telefon` ve `Bilgisayar` sınıflarında ezilmesi gereken soyut metot.
  - `virtual PrintInfo()`: Ürün bilgilerini konsola yazdırır.

#### Telefon
`Telefon`, `BaseMakine` sınıfından türetilmiş olup `IsTurkishLicensed` özelliğine sahiptir.

- **Özellikler**:
  - `IsTurkishLicensed`: Türkiye lisansı olup olmadığını belirtir.
- **Metotlar**:
  - `override GetProductName()`: Ürün adını özel bir formatta döndürür.
  - `override PrintInfo()`: Temel bilgileri ve Türkiye lisans bilgisini ekrana yazdırır.

#### Bilgisayar
`Bilgisayar`, `BaseMakine` sınıfından türetilmiş olup `UsbPortCount` ve `HasBluetooth` özelliklerine sahiptir.

- **Özellikler**:
  - `UsbPortCount`: USB giriş sayısını belirtir, sadece `2` veya `4` olarak atanabilir, aksi durumda `-1` atanır.
  - `HasBluetooth`: Bluetooth özelliği olup olmadığını belirtir.
- **Metotlar**:
  - `override GetProductName()`: Ürün adını özel bir formatta döndürür.
  - `override PrintInfo()`: Temel bilgileri ve USB, Bluetooth bilgilerini ekrana yazdırır.

## Explanation

### Encapsulation
`Bilgisayar` sınıfında `UsbPortCount` özelliği kapsüllenmiştir. Yalnızca `2` veya `4` değerleri kabul edilir; aksi durumda `-1` atanır.

### Inheritance
`Telefon` ve `Bilgisayar` sınıfları, `BaseMakine` sınıfından türetilmiştir. Ortak özellikler ve işlevler temel sınıfta toplanır.

### Polymorphism
`BaseMakine` sınıfındaki `PrintInfo()` metodu, alt sınıflar tarafından ezilmiştir, böylece her ürün kendine özgü bilgileri ekrana yazdırabilir.

### Abstraction
`BaseMakine` sınıfında `GetProductName()` soyut bir metod olarak tanımlanmış, her alt sınıfta kendine özel olarak tanımlanmıştır.

## Usage

1. Uygulama açıldığında, kullanıcıdan Telefon üretmek için `1`, Bilgisayar üretmek için `2` girmesi istenir.
2. Kullanıcı ürün türünü seçtikten sonra ilgili sınıftan bir nesne oluşturulur ve gerekli özellikler kullanıcıdan alınır.
3. Ürün oluşturulduktan sonra tüm bilgileri ekrana yazdırılır.
4. Kullanıcıya başka bir ürün üretmek isteyip istemediği sorulur. Evet yanıtı alınırsa başa dönülür, hayır ise uygulama sonlanır.

## Output

Aşağıda örnek bir çıktı gösterilmiştir:

```
Telefon üretmek için 1'e, bilgisayar üretmek için 2'ye basınız: 1

Telefon Adı: iPhone

Seri Numarası: 123456

Açıklama: Son model akıllı telefon

İşletim Sistemi: iOS

Türkiye Lisanslı mı? (E/H): E

---

**Telefon başarıyla üretildi!**

Üretim Tarihi: 10/10/2024

Seri Numarası: 123456

Ad: iPhone

Açıklama: Son model akıllı telefon

İşletim Sistemi: iOS

Türkiye Lisanslı mı?: True

Telefonunuzun adı ---> iPhone

---

Başka bir ürün üretmek ister misiniz? (E/H): H

**İyi günler dileriz!**
```

## License

This project is licensed under the MIT License.
