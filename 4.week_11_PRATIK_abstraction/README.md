
# Çalışan Yönetim Sistemi

Bu proje, şirket çalışanlarını yönetmek amacıyla `Abstraction` prensibini kullanarak bir sınıf hiyerarşisi oluşturan basit bir C# uygulamasıdır. Her çalışanın adı, soyadı, departmanı gibi ortak özellikleri bulunmakla birlikte görevleri (pozisyonları) farklıdır. 

`Gorev` metodu, her çalışanın yaptığı işi konsolda yazdıracak şekilde özelleştirilmiştir. 

## Table of Contents

- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
  - [1. Temel Sınıf: Calisan](#temel-sınıf-calisan)
  - [2. Türeyen Sınıflar](#türeyen-sınıflar)
  - [3. Gorev Metodu Uygulaması](#gorev-metodu-uygulaması)
- [Usage](#usage)
- [Output](#output)
- [License](#license)

---

## Introduction

Bu proje, bir şirketin çalışanlarını temsil eden soyut bir sınıf yapısı oluşturarak `Abstraction` ve `Inheritance` kavramlarını uygulamayı amaçlar. Çalışanlar için ortak özellikleri barındıran `Calisan` adlı soyut sınıf, her çalışan türüne göre özelleştirilen `Gorev` metoduyla genişletilir.

## Technologies

- C#
- .NET SDK

## Code Overview

### 1. Temel Sınıf: `Calisan`

`Calisan` sınıfı, çalışanlar için ad, soyad ve departman gibi ortak özellikleri tanımlar ve `Gorev` adlı soyut bir metot içerir. Bu sınıf, her çalışan türü için bu metodun farklı uygulanabilmesini sağlar.

```csharp
public abstract class Calisan
{
    // Çalışanın adı, soyadı ve departmanı
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Departman { get; set; }

    // Görevin tanımlandığı soyut metot
    public abstract void Gorev();
}
```

### 2. Türeyen Sınıflar

Her çalışan türü (`YazilimGelistirici`, `ProjeYoneticisi`, `SatisTemsilcisi`), `Calisan` sınıfından türetilmiş olup, kendi görevini belirten `Gorev` metodunu içerir. Her sınıf, kendi görev tanımını bu metotta konsola yazdırır.

```csharp
public class YazilimGelistirici : Calisan
{
    public override void Gorev()
    {
        Console.WriteLine($"{Ad} {Soyad} yazılım geliştirici olarak çalışıyorum.");
    }
}

public class ProjeYoneticisi : Calisan
{
    public override void Gorev()
    {
        Console.WriteLine($"{Ad} {Soyad} proje yöneticisi olarak çalışıyorum.");
    }
}

public class SatisTemsilcisi : Calisan
{
    public override void Gorev()
    {
        Console.WriteLine($"{Ad} {Soyad} satış temsilcisi olarak çalışıyorum.");
    }
}
```

### 3. `Gorev` Metodu Uygulaması

Bu bölümde her çalışanın görev tanımını nasıl özelleştirdiği gösterilmiştir. `Gorev` metodu, çalışanların isimlerine ve pozisyonlarına göre çıktıyı sağlar.

## Usage

Projeyi çalıştırmak için .NET SDK kurulu olduğundan emin olun. Proje, her bir çalışan sınıfının görevini `Gorev` metodunu çağırarak konsola yansıtır.

1. **Projeyi çalıştırın**:
   ```bash
   dotnet run
   ```

2. **Örnek Çıktılar**:

   ```plaintext
   Hasan Çıldırmış proje yöneticisi olarak çalışıyorum.
   Zeynep Yazılımcı yazılım geliştirici olarak çalışıyorum.
   Ahmet Satış satış temsilcisi olarak çalışıyorum.
   ```

## Output

Uygulama çalıştığında, her çalışanın görev tanımı belirtilen sınıf metoduyla konsolda görüntülenir.

## License

Bu proje MIT Lisansı altında lisanslanmıştır. Daha fazla bilgi için LICENSE dosyasını inceleyebilirsiniz.
