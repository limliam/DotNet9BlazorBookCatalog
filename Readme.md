
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


