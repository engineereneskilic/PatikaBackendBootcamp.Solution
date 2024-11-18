
# Singers and Album Information - Patikafy Music

This project is a C# console application that performs various queries on a list of singers. It allows users to filter, sort, and analyze singer data based on specific criteria.

## Table of Contents
- [Requirements](#requirements)
- [Usage](#usage)
- [Code Explanations](#code-explanations)
  - [Singers Whose Names Start with 'S'](#singers-whose-names-start-with-s)
  - [Singers with Album Sales Over 10 Million](#singers-with-album-sales-over-10-million)
  - [Singers Who Debuted Before 2000 and Perform Pop Music](#singers-who-debuted-before-2000-and-perform-pop-music)
  - [Singer with the Highest Album Sales](#singer-with-the-highest-album-sales)
  - [Newest and Oldest Debut Singers](#newest-and-oldest-debut-singers)

---

## Requirements

- .NET SDK (6.0 or later)
- A code editor (Visual Studio or Visual Studio Code)

---

## Usage

1. Clone or download the repository.
2. Open the project in your preferred IDE.
3. Run the application to see the queries executed on the singer data.

---

## Code Explanations

### Singers Whose Names Start with 'S'

This query filters the list to find singers whose names begin with the letter 'S'. 

```csharp
var singersStartingWithS = singers.Where(s => s.Name.StartsWith("S")).ToList();
```

**Example Output:**
- Sezen Aksu
- Sertab Erener
- Sıla
- Serdar Ortaç

---

### Singers with Album Sales Over 10 Million

This query retrieves singers whose album sales exceed 10 million.

```csharp
var highSellingSingers = singers.Where(s => s.AlbumSales > 10_000_000).ToList();
```

**Example Output:**
- Ajda Pekkan
- Tarkan
- Serdar Ortaç

---

### Singers Who Debuted Before 2000 and Perform Pop Music

This query filters singers who debuted before the year 2000 and are categorized as pop artists. The results are grouped by debut year and sorted alphabetically.

```csharp
var popSingersBefore2000 = singers
    .Where(s => s.DebutYear < 2000 && s.MusicType.Contains("Pop"))
    .GroupBy(s => s.DebutYear)
    .OrderBy(g => g.Key)
    .ToList();
```

**Example Output:**
- **1968:** Ajda Pekkan  
- **1971:** Sezen Aksu  
- **1994:** Sertab Erener, Serdar Ortaç  
- **1999:** Funda Arar, Hande Yener  

---

### Singer with the Highest Album Sales

This query identifies the singer with the highest album sales.

```csharp
var topSeller = singers.OrderByDescending(s => s.AlbumSales).First();
```

**Example Output:**  
- **Tarkan** with approximately 40 million sales.

---

### Newest and Oldest Debut Singers

This query finds the singers with the earliest and latest debut years.

```csharp
var newestDebut = singers.OrderByDescending(s => s.DebutYear).First();
var oldestDebut = singers.OrderBy(s => s.DebutYear).First();
```

**Example Output:**  
- **Newest Debut:** Sıla (2009)  
- **Oldest Debut:** Neşet Ertaş (1960)
