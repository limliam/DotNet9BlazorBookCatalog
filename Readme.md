
# Blazor Web App with EF Core in .NET 9

This project demonstrates basic CRUD operations using **Entity Framework Core** with **SQL Server** in a **Blazor Web App** built on the latest **.NET 9**. It is developed using Visual Studio 2022 and follows modern best practices such as **Clean Architecture** for interactive web applications.

The application utilizes **Interactive Server-Side Rendering (SSR)** for seamless user interaction and leverages **Code-First Database Migrations** to manage database schema updates efficiently.

This project is currently hosted in Azure App Service.

## Key Features

- **Blazor Web App (.NET 9)** – A modern framework for building interactive web applications.
- **Razor Components** – Reusable UI components for building dynamic web applications.
- **Interactive Server-Side Rendering (SSR)** – Enhances performance and reduces client-side load.
- **Entity Framework Core** – A lightweight, high-performance ORM for database interactions.
- **SQL Server** – A powerful, scalable relational database management system.
- **Code-First Database Migration** – Enables schema creation and updates directly from model classes.
- **CRUD Operations** – Implementation of essential database operations (_Create, Read, Update, Delete_).
- **Reusable Form Component** – Simplifies add and update operations for better maintainability.
- **Streaming Rendering** – Improves performance by progressively loading content.
- **Clean Architecture** – Follows best practices for separation of concerns and scalability.

## Solution Structure

- **Front-End Client:** Blazor Web App for the UI layer.
- **Application Layer:** Contains business logic and interfaces.
- **Domain Layer:** Defines core business entities and rules.
- **Infrastructure Layer:** Manages database access, external APIs, and other services.



--------------------------------------------------------------

# Clean Architecture:
Blank solution
Class Library x3
Blazer WebApp x1

# Add Project References where needed
# DotNet9BlazorBookCatalog (Blazor WebApp) >  Set as Startup Project

# Remove unused using statement
# Change internal to public when create new class or interface

# Install packages:
Tools > NuGet Package Manager > Package Manager Console

Project: DotNet9BlazorBookCatalog.Infrastructure
PM> install-package Microsoft.EntityFrameworkCore.SqlServer
PM> install-package Microsoft.EntityFrameworkCore.Tools

# for Sqlite 
PM> Install-Package Microsoft.EntityFrameworkCore.Sqlite

Project: DotNet9BlazorBookCatalog
PM> install-package Microsoft.EntityFrameworkCore.Design

# Database
Project: DotNet9BlazorBookCatalog.Infrastructure
PM> add-migration Initial
PM> update-database

# Git
CMD go to the project. ..\DotNet9BlazorBookCatalog>

> git --version
> git config --global user.name

> notepad .gitignore
.vs/
bin/
obj/
*.user
*.suo
*.vssscc
*.vspscc
Save and close the .gitignore file.

> git add . 
> git commit -m "Initial commit"

Go to Git and create repository 'DotNet9BlazorBookCatalog' and copy the repository URL

> git remote add origin https://github.com/limliam/DotNet9BlazorBookCatalog.git
> git push -u origin master

Delete main branch.
 
> git fetch --all
> git branch
> git branch -r
> git push origin --delete main