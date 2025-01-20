
# Soccer Jersey Shop (ASP.NET)

Soccer Jersey Shop is a web application built with ASP.NET Core. It allows users to browse, search, and purchase soccer jerseys. This project demonstrates the use of server-side rendering, data management, and a clean MVC architecture.

## Features

- **User Authentication**: Secure login and signup functionality for users.
- **Jersey Catalog**: Browse a wide selection of soccer jerseys with details and images.
- **Search Functionality**: Find jerseys by team, player, or brand.
- **Shopping Cart**: Add jerseys to the cart and proceed to checkout.
- **Responsive Design**: Optimized for both desktop and mobile devices.

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/superALLEY/soccerJersey-ASP.NET.git
   cd soccerJersey-ASP.NET
   ```

2. Open the project in Visual Studio.

3. Restore NuGet packages:
   - Go to `Tools` -> `NuGet Package Manager` -> `Manage NuGet Packages for Solution...`.
   - Install any missing dependencies.

4. Set up the database:
   - Update the connection string in `appsettings.json`:
     ```json
     "ConnectionStrings": {
         "DefaultConnection": "Server=<your_server>;Database=SoccerJerseyDB;Trusted_Connection=True;"
     }
     ```
   - Run the migrations to create the database:
     ```bash
     dotnet ef database update
     ```

5. Run the application:
   - Press `F5` or click the "Run" button in Visual Studio.

6. Open your browser and navigate to `https://localhost:5001`.

## Technologies Used

- **Frontend**:
  - Razor Pages
  - HTML/CSS
  - Bootstrap

- **Backend**:
  - ASP.NET Core
  - Entity Framework Core

- **Database**:
  - SQL Server

- **Authentication**:
  - ASP.NET Identity

## Folder Structure

```
soccerJersey-ASP.NET/
├── Controllers/      # Application controllers
├── Models/           # Application models
├── Views/            # Razor views for UI rendering
├── wwwroot/          # Static files (CSS, JS, images)
├── appsettings.json  # Configuration file
├── Program.cs        # Main application entry point
├── Startup.cs        # Application configuration
```

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.

## Contributing

Contributions are welcome! Feel free to open an issue or submit a pull request.

---

Enjoy exploring the Soccer Jersey Shop! ⚽
