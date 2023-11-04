# TDD Övning 1 - C# with NUnit

This solution contains two projects:
- A C# class library project called `Skottår Kalkylator`
- A NUnit test project called `Skottår Test` med `KalkylatorTests.cs`

Båda använder `net7.0`

## Innan du börjar:
- Gör ett steg/krav i taget.
- Försök att inte läsa framåt.
- Meningen är att lära sig att arbeta stegvis.
- Testa först!

## Flöde
1. Skriv ett failing test
2. Skriv lagom mycket kod för att den ska passera
3. Refaktorera
4. Upprepa igen

## Beskrivning

Implementera `ÄrSkottår()`-funktionen i klassen `År`, så att den returnerar `true`
eller `false` beroende på om dess inmatade heltal är ett skottår eller inte.

### Steg/Krav 1
Alla år delbara med 400 ÄR skottår (så till exempel var 2000 verkligen ett skottår)

-----------------------------------------------------------------------------------

### Steg/Krav 2
Alla år som är delbara med 100 men inte med 400 är INTE skottår (så till exempel 1700, 1800 och 1900 var INTE skottår, inte heller kommer 2100 att vara ett skottår)

-----------------------------------------------------------------------------------

### Steg/Krav 3
Alla år delbara med 4 men inte med 100 ÄR skottår (t.ex. 2008, 2012, 2016)

-----------------------------------------------------------------------------------

### Steg/Krav 4
Alla år som inte är delbara med 4 är INTE skottår (t.ex. 2017, 2018, 2019)

-----------------------------------------------------------------------------------

## Bonus steg/krav

### Steg/Krav 5
Skriv en funktion `FåDagNummer()` som tar ett datum som ett argument och returnerar dagen på året. t.ex.:
- 1 januari 2023 --> returnerar 1
- 31 december 2022 --> returnerar 365
- 1 mars 2023 --> returnerar 60
- 1 mars 2020 --> returnerar 61

-----------------------------------------------------------------------------------

### Steg/Krav 6
Skriv en funktion `FåVeckaNummer()` som tar ett datum som ett argument och returnerar kalenderveckan, t.ex.:
- 29 mars 2023 --> returnerar vecka 13

-----------------------------------------------------------------------------------

### Steg/Krav 7
Skriv en funktion `FåVeckoDag()` som tar ett datum som ett argument och returnerar veckodagen, t.ex.:
- 29 mars 2023 --> returnerar Onsdag

-----------------------------------------------------------------------------------

## Namngivning TESTS

Use the following naming convention:

```csharp
När[MethodUnderTest][Scenario]_[Då]_[Förväntat resultat]
```

## Strukturera TESTS

Använd 3 A:
```csharp
public void IsAdult_AgeIs18_ReturnsTrue()
{
    // Arrange
    var user = new User(18);

    // Act
    var result = user.IsAdult();

    // Assert
    Assert.That(result, Is.True);
}
```
