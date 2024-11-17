
# LinqPratikleri: İşlevsel Liste İşlemleri

## Introduction
Bu proje, C# programlama dili ve LINQ (Language Integrated Query) kullanılarak rastgele oluşturulan bir liste üzerinde çeşitli işlemleri gerçekleştirmek için hazırlanmıştır. Program, farklı LINQ sorgularını kullanarak liste elemanlarını filtreler, dönüştürür ve analiz eder. Proje eğitim amacıyla hazırlanmıştır ve LINQ sorgularının nasıl kullanıldığını anlamanızı sağlar.

## Technologies
- **C# .NET Core**
- **LINQ (Language Integrated Query)**
- **Visual Studio IDE veya benzer bir IDE**

## Code Overview
Bu uygulama, rastgele oluşturulan bir liste üzerinde aşağıdaki işlemleri gerçekleştirmektedir:
- Çift ve tek sayıların ayrıştırılması
- Negatif ve pozitif sayıların ayrıştırılması
- Belirli bir aralıktaki sayıların filtrelenmesi
- Liste elemanlarının karelerinin hesaplanması

## Explanation

### 1. Liste Oluşturma
Rastgele -50 ile 50 arasında değerler üreten 10 elemanlı bir liste oluşturulur.
```csharp
Random random = new Random();
List<int> numbers = new List<int>();
for (int i = 0; i < 10; i++)
{
    numbers.Add(random.Next(-50, 51));
}
```
**Örnek Çıktı:**
```
Liste:
-10
15
23
-8
42
0
-31
7
50
-2
```

---

### 2. Çift Sayılar
Listenin çift sayılarını filtrelemek için `Where` metodu kullanılır.
```csharp
var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
```
**Örnek Çıktı:**
```
Çift Olan Sayılar:
-10
-8
42
0
50
-2
```

---

### 3. Tek Sayılar
Listenin tek sayılarını filtrelemek için `Where` metodu kullanılır.
```csharp
var oddNumbers = numbers.Where(n => n % 2 != 0).ToList();
```
**Örnek Çıktı:**
```
Tek Olan Sayılar:
15
23
-31
7
```

---

### 4. Negatif Sayılar
Listenin negatif sayılarını filtrelemek için `Where` metodu kullanılır.
```csharp
var negativeNumbers = numbers.Where(n => n < 0).ToList();
```
**Örnek Çıktı:**
```
Negatif Sayılar:
-10
-8
-31
-2
```

---

### 5. Pozitif Sayılar
Listenin pozitif sayılarını filtrelemek için `Where` metodu kullanılır.
```csharp
var positiveNumbers = numbers.Where(n => n > 0).ToList();
```
**Örnek Çıktı:**
```
Pozitif Sayılar:
15
23
42
7
50
```

---

### 6. Belirli Bir Aralıkta Sayılar
15'ten büyük ve 22'den küçük sayıların filtrelenmesi için `Where` metodu kullanılır.
```csharp
var rangeNumbers = numbers.Where(n => n > 15 && n < 22).ToList();
```
**Örnek Çıktı:**
```
15'ten Büyük ve 22'den Küçük Sayılar:
```
(*Not: Çıktı rastgele değerlere göre değişiklik gösterebilir.*)

---

### 7. Sayıların Kareleri
Listenin her bir elemanının karesi hesaplanır.
```csharp
var squaredNumbers = numbers.Select(n => n * n).ToList();
```
**Örnek Çıktı:**
```
Listedeki Sayıların Kareleri:
100
225
529
64
1764
0
961
49
2500
4
```

---

## Usage
1. **Kodu Çalıştırma:**
   - Projeyi bir IDE'de açın (örneğin, Visual Studio).
   - Çalıştırarak rastgele liste üzerindeki sorguları gözlemleyin.

2. **Çıktılar:**
   - Program, her sorgu için çıktıyı konsola yazar.

---

## Output
Programın çalıştırılması sonucunda, her bir sorgu için detaylı çıktı konsola yazdırılır. Örnek çıktılar yukarıda verilmiştir.

---

## License
Bu proje, MIT lisansı ile lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasına göz atabilirsiniz.
