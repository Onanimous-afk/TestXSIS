# Movies REST API

A RESTful API for retrieving information about movies. 

## Features

- Retrieve a list of all movies
- Retrieve information about a specific movie
- Add a new movie to the database
- Update information about an existing movie
- Delete a movie from the database

## Technologies Used

- C#
- ASP.NET Core
- Entity Framework Core
- MYSQL Database

## Getting Started

1. Clone the repository
2. Navigate to the project directory
3. Restore the NuGet packages
4. Update the connection string in the `appsettings.json` file to match your SQL Server configuration
5. Import the database


The API will be available at `https://localhost:7273/api/movie`

## Endpoints

### GET /api/movie

Retrieves a list of all movies

### GET /api/movie/{id}

Retrieves information about a specific movie

### POST /api/movie

Adds a new movie to the database

### PUT /api/movie/{id}

Updates information about an existing movie

### DELETE /api/movie/{id}

Deletes a movie from the database

## License

This project is licensed under the [MIT License](LICENSE).

