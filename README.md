# GameCollectionManagement

## Table of Contents
- [Description](#description)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Installation](#installation)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Contributing](#contributing)
- [License](#license)


## Description
GameCollectionManagement is a comprehensive C# application that empowers users to efficiently manage their video game collections. Designed for both casual gamers and dedicated collectors, this application allows users to organize their game libraries with ease. Users can track their game titles, genres, release dates, and platforms, all in a user-friendly interface. 

The goal of this project is to simplify the process of cataloging video games, ensuring that users always know what games they own and on which platform they can play them.

## Features
- **Game Management:** Add, edit, and delete game entries.
- **Search and Filter:** Quickly find games using search and filter options based on title, genre, platform, etc.
- **User-Friendly Interface:** A clean and intuitive interface built with WinForms, making it easy for users of all technical levels to manage their collections.
- **Data Persistence:** All data is stored securely in a SQL Server database, ensuring that user data is always safe and accessible.
- **Cross-Platform Compatibility:** Built on .NET, the application can be easily modified to run on different operating systems.

## Technologies Used
- **C#**: The core programming language used for building the application.
- **.NET Framework**: Provides the base framework for building and running the application.
- **WinForms**: Used to create the graphical user interface (GUI) for a smooth user experience.
- **SQL Server**: A relational database management system used to store game data.
- **Entity Framework**: An ORM (Object-Relational Mapping) tool that simplifies database operations by allowing developers to work with data as objects.
- **Git**: Version control system used to manage and track changes in the codebase.
- **Visual Studio**: The integrated development environment (IDE) used for development.

## Installation
### Prerequisites
- .NET Framework 4.x or higher
- SQL Server (LocalDB or full installation)
- Visual Studio 2019 or higher

### Steps
1. **Clone the Repository**: Clone the repository to your local machine using Git.

   ```bash
   git clone https://github.com/kaankaya/GameCollectionManagement.git
   
2.Open Solution: Open the GameCollectionManagement.sln file in Visual Studio.

3.Restore Dependencies: Restore the required NuGet packages.

4.Configure Database:

  - Ensure that SQL Server is installed and running.
  - 
  - Update the connection string in App.config if necessary.
    
5.Build and Run: Build the solution and run the application.

## Usage
- **Adding a Game:** Navigate to the "Add Game" section, fill in the details, and click "Save".
- **Editing a Game:** Select a game from the list, click "Edit", make your changes, and click "Update".
- **Deleting a Game:** Select a game and click "Delete" to remove it from your collection.
- **Viewing Collection:** Browse your entire game library in the main view with options to search and filter.

## Project Structure
The project is organized into the following major folders and files:

- **/GameCollectionManagement**: Contains the main application code.
  - **/Models**: Entity classes representing the data structure.
  - **/Data**: Database context and migration files.
  - **/Views**: WinForms forms for the GUI.
  - **/Controllers**: Business logic for managing game data.
- **/GameCollectionManagement.Tests**: Unit and integration tests for the application.
- **/GameCollectionManagement.sln**: The solution file for the project.

## Contributing
Contributions are welcome! To contribute:

1. **Fork the repository.**
2. **Create a new branch (`feature-xyz`).**
3. **Implement your feature or fix.**
4. **Commit and push to your branch.**
5. **Submit a pull request for review.**

Please ensure your code follows the project's coding standards and is well-documented.

## License
This project is licensed under the MIT License. See the LICENSE file for more information.
