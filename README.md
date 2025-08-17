refactor(api): extract presentation layer setup into WebApplicationBuilder extension

- Created `WebApplicationBuilderExtensions` in a new `Extensions` folder within the API project
- Moved presentation-related service registrations (e.g., AddControllers, AddSwagger, middleware setup) into `AddPresentation` extension method
- Applied `AddPresentation` in `Program.cs` to simplify and declutter the main setup logic
- Cleaned up unused namespaces in `Program.cs`
- Verified functionality via Swagger UI and API endpoint testing
