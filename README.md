# Avanceret Programmering Eksamen

Et ASP.NET MVC projekt der implementerer et belønningssystem til salg ved hjælp af Strategy Pattern.

## Beskrivelse

Dette projekt demonstrerer brugen af design patterns, specielt Strategy Pattern, til at beregne belønninger baseret på forskellige kriterier som salgspris og kundetilfredshed.

## Projekt Struktur

- **Models/** - Datamodeller (Sale, RewardModel, etc.)
- **Strategies/** - Implementeringer af forskellige belønningsstrategier
  - `IRewardStrategy` - Interface for reward strategier
  - `SalesPriceRewardStrategy` - Belønning baseret på salgspris
  - `CustomerSatisfactionRewardStrategy` - Belønning baseret på kundetilfredshed
  - `CombinedRewardStrategy` - Kombineret strategi
  - `AdapterRewardStrategy` - Adapter pattern implementation
- **Controllers/** - MVC controllers
- **Views/** - Razor views
- **TestProject/** - Unit tests
- **TredjepartsProjekt/** - Tredjepartsintegration med adapter pattern

## Teknologier

- ASP.NET Core MVC
- C# .NET
- JSON data persistence

## Kom i gang

1. Åbn `AvanceretProgrammeringEksamen.sln` i Visual Studio
2. Build projektet
3. Kør applikationen (F5)

## Kør tests

Projektet inkluderer unit tests i `TestProject/` mappen.

```bash
dotnet test
```

## Data

Salgsdata gemmes i `fileSales.json`.
