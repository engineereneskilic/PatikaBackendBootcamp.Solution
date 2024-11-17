## Örnek LINQ Sorguları

### C# LINQ Metotları

1. **Where**: Bir koleksiyon üzerinde filtreleme yapar.
2. **Select**: Her bir öğeyi dönüştürmek için kullanılır (örneğin, belirli özellikleri seçmek).
3. **OrderBy / OrderByDescending**: Koleksiyonu artan veya azalan sırada sıralar.
4. **GroupBy**: Belirli bir özelliğe göre gruplama yapar.
5. **First / FirstOrDefault**: İlk öğeyi veya belirli bir koşulu sağlayan ilk öğeyi döndürür. Bulunamazsa `FirstOrDefault` `null` veya `default` değeri döner.
6. **Last / LastOrDefault**: Son öğeyi veya belirli bir koşulu sağlayan son öğeyi döndürür.
7. **Take / Skip**: Belirli bir sayıda öğe alır veya atlar.
8. **Count**: Eleman sayısını döndürür.
9. **Sum / Min / Max / Average**: Numerik özellikler üzerinde toplam, minimum, maksimum veya ortalama değeri hesaplar.
10. **Any / All**: Bir koleksiyonda en az bir öğenin bir koşulu sağlayıp sağlamadığını veya tüm öğelerin bir koşulu sağlayıp sağlamadığını kontrol eder.
11. **Distinct**: Tekrarlanan öğeleri kaldırır (özellikle değer türlerinde kullanışlıdır).
12. **Join**: İki koleksiyon üzerinde birleşim yapar (genellikle `ForeignKey` benzeri bağlamlarda).
13. **ToList / ToArray**: Koleksiyonu bir listeye veya diziye dönüştürür.


### Ülkeler Tablosu

| Id  | Ad                           | Başkent             |
|-----|-----------------------------|---------------------|
| TR  | Türkiye                      | Ankara              |
| US  | Amerika Birleşik Devletleri  | Washington, D.C.    |
| DE  | Almanya                      | Berlin              |
| FR  | Fransa                       | Paris               |
| JP  | Japonya                      | Tokyo               |
| GB  | Birleşik Krallık             | Londra              |
| IT  | İtalya                       | Roma                |
| ES  | İspanya                      | Madrid              |
| CN  | Çin                          | Pekin               |
| RU  | Rusya                        | Moskova             |
| IN  | Hindistan                    | Yeni Delhi          |
| BR  | Brezilya                     | Brezilya Şehri      |

### Ünlüler Tablosu

| Id  | Ad                 | Doğum Yılı | Meslek                        | Ülke Id |
|-----|--------------------|------------|------------------------------|---------|
| 1   | Fazıl Say          | 1970       | Piyanist ve Besteci          | TR      |
| 2   | Elif Şafak         | 1971       | Yazar                        | TR      |
| 3   | Sebastian Vettel   | 1987       | Formula 1 Pilotu             | DE      |
| 4   | Heidi Klum         | 1973       | Model ve TV Sunucusu         | DE      |
| 5   | Leonardo DiCaprio  | 1974       | Oyuncu                       | US      |
| 6   | Taylor Swift       | 1989       | Şarkıcı ve Söz Yazarı        | US      |
| 7   | Marion Cotillard   | 1975       | Oyuncu                       | FR      |
| 8   | Julien Bam         | 1988       | YouTuber ve İçerik Üreticisi | FR      |
| 9   | Benedict Cumberbatch| 1976      | Oyuncu                       | GB      |
| 10  | Ed Sheeran         | 1991       | Şarkıcı ve Söz Yazarı        | GB      |
| 11  | Andrea Bocelli     | 1958       | Opera Tenoru                 | IT      |
| 12  | Chiara Ferragni    | 1987       | Moda İkonu ve Influencer     | IT      |
| 13  | Javier Bardem      | 1969       | Oyuncu                       | ES      |
| 14  | Rafael Nadal       | 1986       | Tenisçi                      | ES      |
| 15  | A.R. Rahman        | 1967       | Müzik Bestecisi              | IN      |
| 16  | Priyanka Chopra    | 1982       | Oyuncu ve Şarkıcı            | IN      |
| 17  | Anna Netrebko      | 1971       | Opera Sanatçısı              | RU      |
| 18  | Evgeny Kissin      | 1971       | Piyanist                     | RU      |
| 19  | Jack Ma            | 1964       | İş İnsanı                    | CN      |
| 20  | Yao Ming           | 1980       | Basketbolcu                  | CN      |
| 21  | Hayao Miyazaki     | 1941       | Animatör ve Yönetmen         | JP      |
| 22  | Naomi Osaka        | 1997       | Tenisçi                      | JP      |
| 23  | Sir Patrick Stewart| 1940       | Oyuncu                       | GB      |
| 24  | Emma Watson        | 1990       | Oyuncu ve Aktivist           | GB      |
| 25  | Adriana Lima       | 1981       | Model                        | BR      |
| 26  | Rodrigo Santoro    | 1975       | Oyuncu                       | BR      |
| 27  | Penélope Cruz      | 1974       | Oyuncu                       | ES      |
| 28  | Eros Ramazzotti    | 1963       | Şarkıcı ve Besteci           | IT      |
| 29  | Jean Reno          | 1948       | Oyuncu                       | FR      |
| 30  | Jeff Koons         | 1955       | Sanatçı                      | US      |

### C# Kodu

### C# Ülkeler Listesi

```csharp
public class Unlu
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public int DogumYili { get; set; }
    public string Meslek { get; set; }
    public string UlkeId { get; set; }
}

public class Ulke
{
    public string Id { get; set; }
    public string Ad { get; set; }
    public string Baskent { get; set; }
}

List<Ulke> ulkeler = new List<Ulke>
{
    new Ulke { Id = "TR", Ad = "Türkiye", Baskent = "Ankara" },
    new Ulke { Id = "US", Ad = "Amerika Birleşik Devletleri", Baskent = "Washington, D.C." },
    new Ulke { Id = "DE", Ad = "Almanya", Baskent = "Berlin" },
    new Ulke { Id = "FR", Ad = "Fransa", Baskent = "Paris" },
    new Ulke { Id = "JP", Ad = "Japonya", Baskent = "Tokyo" },
    new Ulke { Id = "GB", Ad = "Birleşik Krallık", Baskent = "Londra" },
    new Ulke { Id = "IT", Ad = "İtalya", Baskent = "Roma" },
    new Ulke { Id = "ES", Ad = "İspanya", Baskent = "Madrid" },
    new Ulke { Id = "CN", Ad = "Çin", Baskent = "Pekin" },
    new Ulke { Id = "RU", Ad = "Rusya", Baskent = "Moskova" },
    new Ulke { Id = "IN", Ad = "Hindistan", Baskent = "Yeni Delhi" },
    new Ulke { Id = "BR", Ad = "Brezilya", Baskent = "Brezilya Şehri" }
};

List<Unlu> unluler = new List<Unlu>
{
    new Unlu { Id = 1, Ad = "Fazıl Say", DogumYili = 1970, Meslek = "Piyanist ve Besteci", UlkeId = "TR" },
    new Unlu { Id = 2, Ad = "Elif Şafak", DogumYili = 1971, Meslek = "Yazar", UlkeId = "TR" },
    new Unlu { Id = 3, Ad = "Sebastian Vettel", DogumYili = 1987, Meslek = "Formula 1 Pilotu", UlkeId = "DE" },
    new Unlu { Id = 4, Ad = "Heidi Klum", DogumYili = 1973, Meslek = "Model ve TV Sunucusu", UlkeId = "DE" },
    new Unlu { Id = 5, Ad = "Leonardo DiCaprio", DogumYili = 1974, Meslek = "Oyuncu", UlkeId = "US" },
    new Unlu { Id = 6, Ad = "Taylor Swift", DogumYili = 1989, Meslek = "Şarkıcı ve Söz Yazarı", UlkeId = "US" },
    new Unlu { Id = 7, Ad = "Marion Cotillard", DogumYili = 1975, Meslek = "Oyuncu", UlkeId = "FR" },
    new Unlu { Id = 8, Ad = "Julien Bam", DogumYili = 1988, Meslek = "YouTuber ve İçerik Üreticisi", UlkeId = "FR" },
    new Unlu { Id = 9, Ad = "Benedict Cumberbatch", DogumYili = 1976, Meslek = "Oyuncu", UlkeId = "GB" },
    new Unlu { Id = 10, Ad = "Ed Sheeran", DogumYili = 1991, Meslek = "Şarkıcı ve Söz Yazarı", UlkeId = "GB" },
    new Unlu { Id = 11, Ad = "Andrea Bocelli", DogumYili = 1958, Meslek = "Opera Tenoru", UlkeId = "IT" },
    new Unlu { Id = 12, Ad = "Chiara Ferragni", DogumYili = 1987, Meslek = "Moda İkonu ve Influencer", UlkeId = "IT" },
    new Unlu { Id = 13, Ad = "Javier Bardem", DogumYili = 1969, Meslek = "Oyuncu", UlkeId = "ES" },
    new Unlu { Id = 14, Ad = "Rafael Nadal", DogumYili = 1986, Meslek = "Tenisçi", UlkeId = "ES" },
    new Unlu { Id = 15, Ad = "A.R. Rahman", DogumYili = 1967, Meslek = "Müzik Bestecisi", UlkeId = "IN" },
    new Unlu { Id = 16, Ad = "Priyanka Chopra", DogumYili = 1982, Meslek = "Oyuncu ve Şarkıcı", UlkeId = "IN" },
    new Unlu { Id = 17, Ad = "Anna Netrebko", DogumYili = 1971, Meslek = "Opera Sanatçısı", UlkeId = "RU" },
    new Unlu { Id = 18, Ad = "Evgeny Kissin", DogumYili = 1971, Meslek = "Piyanist", UlkeId = "RU" },
    new Unlu { Id = 19, Ad = "Jack Ma", DogumYili = 1964, Meslek = "İş İnsanı", UlkeId = "CN" },
    new Unlu { Id = 20, Ad = "Yao Ming", DogumYili = 1980, Meslek = "Basketbolcu", UlkeId = "CN" },
    new Unlu { Id = 21, Ad = "Hayao Miyazaki", DogumYili = 1941, Meslek = "Animatör ve Yönetmen", UlkeId = "JP" },
    new Unlu { Id = 22, Ad = "Naomi Osaka", DogumYili = 1997, Meslek = "Tenisçi", UlkeId = "JP" },
    new Unlu { Id = 23, Ad = "Sir Patrick Stewart", DogumYili = 1940, Meslek = "Oyuncu", UlkeId = "GB" },
    new Unlu { Id = 24, Ad = "Emma Watson", DogumYili = 1990, Meslek = "Oyuncu ve Aktivist", UlkeId = "GB" },
    new Unlu { Id = 25, Ad = "Adriana Lima", DogumYili = 1981, Meslek = "Model", UlkeId = "BR" },
    new Unlu { Id = 26, Ad = "Rodrigo Santoro", DogumYili = 1975, Meslek = "Oyuncu", UlkeId = "BR" },
    new Unlu { Id = 27, Ad = "Penélope Cruz", DogumYili = 1974, Meslek = "Oyuncu", UlkeId = "ES" },
    new Unlu { Id = 28, Ad = "Eros Ramazzotti", DogumYili = 1963, Meslek = "Şarkıcı ve Besteci", UlkeId = "IT" },
    new Unlu { Id = 29, Ad = "Jean Reno", DogumYili = 1948, Meslek = "Oyuncu", UlkeId = "FR" },
    new Unlu { Id = 30, Ad = "Jeff Koons", DogumYili = 1955, Meslek = "Sanatçı", UlkeId = "US" }
};
```
