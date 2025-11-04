# MVC-based Reward System

Exam project demonstrating reward calculation for insurance sales using design patterns.

## What it does

- Manage insurance sales records
- Calculate customer rewards using different strategies
- Store data in JSON files
- Display sales and rewards in a web interface

## Reward Strategies

The system can calculate rewards in 4 different ways:
1. **Sales Price** - Based on the sale amount
2. **Customer Satisfaction** - Based on satisfaction score
3. **Combined** - Mix of both
4. **Adapter** - Uses an external calculation method

## Built with

- ASP.NET Core MVC
- C# / .NET 8
- Razor views
- JSON file storage (no database)

## Running the project

1. Open `AvanceretProgrammeringEksamen.sln` in Visual Studio
2. Press F5 to run
3. Navigate to the web interface

## Testing

```bash
dotnet test
```

## Project Background

This was my exam project for *Avanceret Programmering*, demonstrating:
- Strategy Pattern
- Adapter Pattern
- MVC architecture
- Object-oriented programming principles

**Note:** This is the original version. See [insurancerewards.dk](https://github.com/DevAsgari/insurancerewards.dk) for the improved version with .NET Web API and Vue 3.
