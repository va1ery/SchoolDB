# SchoolDB
sample cod for course at lms.mai.ru


--General Commands:

dotnet add package Microsoft.EntityFrameworkCore.Sqlite

dotnet add package Microsoft.EntityFrameworkCore.Design

--Command to create Model:

dotnet ef dbcontext scaffold "Data Source=DBStudents.db" Microsoft.EntityFrameworkCore.Sqlite -o Models

--Commands to create database:

dotnet ef migrations add InitialCreate

dotnet ef database update

--Command to fill and query database:

dotnet run

--after initial filling DONT FORGET TO comment out (//) following strings // var context = new SchoolContext(); // DbInitializer.Initialize(context);
