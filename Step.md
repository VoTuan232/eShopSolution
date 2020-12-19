# Create new project => Blank Solution => eShopSolution (E:/Projects)
# Add new project => Asp.net Core WebApplication with MVC pattern => eShopSolution.WebApp -> tang Prenstation
# Add new project => Class libraries .NET Core => eShopSolution.Data ( work with Entity Framework) -> tang Data
# Add new project => Class libraries .NET Core => eShopSolution.Application -> tang Business


## Install Package 
dotnet add package Microsoft.EntityFrameworkCore.SqlServer: Microsoft SQL Server database provider for Entity Framework Core
dotnet add package Microsoft.EntityFrameworkCore.Design : share design time componets for EF Core Tools
Install-Package Microsoft.EntityFrameworkCore.Tools:
	-Add-Migration
	-Drop-Database
	-Get-DbContext
	-Scaffold-DbContext
	-Script-Migrations
	-Update-Database

## Config EF
+ Attribute: [Table("Products")], [Required] in class Entities
+ Fluent API: config at outside Entities