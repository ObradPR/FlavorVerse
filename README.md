# FlavorVerse

C# WebAPI with Code First Approach

## Description

FlavorVerse is a C# WebAPI application that allows users to search for recipes and create their own. It uses the code-first approach with Entity Framework, enabling developers to define their database schema using C# classes and generate the database from these classes.

## Prerequisites

- .NET SDK
- SQL Server or any other compatible database
- Visual Studio (recommended) or any other IDE for C# development

## Getting Started

1. Clone the repository:
```bash
git clone https://github.com/ObradPR/FlavorVerse.git
```
2. Navigate to the project directory
3. Open solution
4. Restore the dependencies:
```bash
dotnet restore
```
5. Set the default startup project to Persistence
6. Open **Package Manager Console** and run the database migrations to create the database schema:
```bash
update-database
```
7. Set the default startup project to WebApi
8. Start the application via https

## Testing
All API tests are available through Postman collection inside the project directory `/Other/Postman/`. Import collection inside the Postman workspace and start testing.

## Documentation
Documentation is available inside the project directory `/Other/Documentation/`.