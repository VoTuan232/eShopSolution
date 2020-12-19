# Configuration EF: 2 Types
+ Attribute: [Table("Products")], [Required] in class Entities
+ Fluent API: config at outside Entities (***)

# RelationShip
+ Product vs Category: Many to Many
+ Order vs Order Detail: One to Many
+ Category vs CategoryTranslation: One to Many

# Migration
## ConnectionString
	- Server: 
		+ Server=. // name server, accept all
		+ Trusted_Connection = true // account window
		+ Database=eShopSolution // name database

## Design Factory: Will run DBContext has IDesignTimeDbContextFactory interface ( ignore other DBContext)
https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#from-a-design-time-factory
- Set Default Project => Package manage console => Run: `Add-Migration Initial` : migration database
- To Undo: Remove Migration
- update-database : create database from file migration