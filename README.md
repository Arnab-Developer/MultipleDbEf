# Multiple DB with EF

This is a demo to show how we can work with two different databases from a single application
with Entity Framework. I also use Entity Framework migration to generate and update the databases.
This demo also shows how we can store Entity Framework `DbContext` classes and migrations into a
separate class library and refer that in an ASP.NET application.

Find the database creation scripts in [CreateDbs.sql](https://github.com/Arnab-Developer/MultipleDbEf/blob/main/CreateDbs.sql).
Also the find the migration commands which I used in [MigrationCommands.md](https://github.com/Arnab-Developer/MultipleDbEf/blob/main/MigrationCommands.md).
