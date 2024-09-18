This is a ASP.NET Core web api that currently uses a local Sql Server. A script for the basic database is included 

dotnet run

https://chatgpt.com/c/95d783e4-2b4d-40cb-b58e-18453d9402f7


Creation Cheat Code List:

dotnet new webapi -n StoreAPI
cd StoreAPI
dotnet run
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools
mkdir Data



dotnet ef dbcontext scaffold "Server=.;Database=[DatabaseName];Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models -t Products
