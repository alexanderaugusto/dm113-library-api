# Library API

This is a RESTful API for managing a library using C#.

## Features

CRUD operations for managing books in the library.

## Technologies Used

- C# programming language
- ASP.NET Core framework
- Entity Framework Core for database operations
- SQLite for the database
- Swagger for API documentation

## Getting Started

To get started with the Library API, follow these steps:

1. Clone the repository: `git clone https://github.com/alexanderaugusto/dm113-library-api.git`
2. Install the required dependencies: `dotnet restore`
4. Run the database migrations: `dotnet ef database update`
5. Start the API: `dotnet run`
6. Access the API documentation at `http://localhost:5000/swagger`

## API Endpoints

The following endpoints are available for interacting with the Library API:

- `GET /api/book` - Get all books in the library.
- `GET /api/book/{id}` - Get a specific book by ID.
- `POST /api/book` - Create a new book.
- `PUT /api/book/{id}` - Update an existing book.
- `DELETE /api/book/{id}` - Delete a book.

For detailed information on how to use each endpoint, refer to the API documentation.

## License

This project is licensed under the [MIT License](LICENSE).
