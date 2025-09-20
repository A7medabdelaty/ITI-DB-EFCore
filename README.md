# ITI_DB

## Overview

ITI_DB is a .NET 9 Entity Framework Core project for managing an educational institute's data, including departments, students, instructors, and courses. The project demonstrates the use of EF Core for database modeling, configuration, and CRUD operations.

## Features

- Entity Framework Core code-first approach
- Models for Department, Student, Instructor, Course, and related entities
- Configuration classes for entity relationships and constraints
- CRUD operations for students and departments
- Console-based interaction for demonstration

## Project Structure

- `Models/` - Entity classes (Department, Student, Instructor, etc.)
- `Configurations/` - EntityTypeConfiguration classes for model configuration
- `Context/ITIContext.cs` - EF Core DbContext setup
- `Program.cs` - Example CRUD operations and data seeding

## Getting Started

1. **Clone the repository:**
   ```bash
   git clone https://github.com/yourusername/ITI_DB.git
   cd ITI_DB
   ```

2. **Configure the database:**
   - Update the connection string in `Context/ITIContext.cs` if needed.

3. **Run the project:**
   - Build and run the solution in Visual Studio 2022 or later.

## Requirements

- .NET 9 SDK
- SQL Server (default connection string uses `.\SQLEXPRESS`)

## Usage

- The application seeds sample departments and students.
- Demonstrates adding, updating, removing, and displaying students via the console.

## License

This project is for educational purposes.