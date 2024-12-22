# NieuwsFlits API

Backend API for the NieuwsFlits news platform, built with .NET 8.

## Features

* RESTful API design
* Entity Framework Core for data management
* SQL Server database integration
* Swagger/OpenAPI documentation
* CORS configuration for frontend integration
* Error handling middleware
* Logging system

## Prerequisites

* .NET 8 SDK
* SQL Server
* Visual Studio 2022 or VS Code

## Installation

1. Clone the repository:
```
git clone https://github.com/marvindeckmyn/nieuwsflits-api.git
cd nieuwsflits-api
```

2. Update the database connection string in `appsettings.json`:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=NieuwsFlitsDb;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}
```

3. Apply database migrations:
```
dotnet ef database update
```

4. Run the application:
```
dotnet run
```

The API will be available at `https://localhost:7001` and `http://localhost:5001` by default.

## API Endpoints

### News Articles

* `GET /api/news/latest` - Get latest news articles
* `GET /api/news/{id}` - Get specific article by ID
* `GET /api/news/category/{category}` - Get articles by category
* `POST /api/news` - Create new article
* `PUT /api/news/{id}` - Update existing article
* `DELETE /api/news/{id}` - Delete article

## Project Structure

```
NieuwsFlits.API/
├── Controllers/         # API controllers
├── Models/             # Domain models
├── Data/               # Database context and configurations
├── Services/           # Business logic
├── Middleware/         # Custom middleware
└── Configuration/      # App configuration classes
```

## Database Schema

### NewsArticle
```csharp
public class NewsArticle
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string Summary { get; set; }
    public int AuthorId { get; set; }
    public DateTime PublishDate { get; set; }
    public string Category { get; set; }
    public string? ImageUrl { get; set; }
    public List<string> Tags { get; set; }
}
```

## Development

### Adding New Migration
```
dotnet ef migrations add MigrationName
```

### Update Database
```
dotnet ef database update
```

### Run in Development Mode
```
dotnet run --environment Development
```

## Testing

* Run unit tests:
```
dotnet test
```

## Contributing

1. Fork the repository
2. Create your feature branch: `git checkout -b feature/my-new-feature`
3. Commit your changes: `git commit -am 'Add some feature'`
4. Push to the branch: `git push origin feature/my-new-feature`
5. Submit a pull request

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🤝 Contact

Marvin Deckmyn - [GitHub Profile](https://github.com/marvindeckmyn)