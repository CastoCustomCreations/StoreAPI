This is a ASP.NET Core web api that currently uses a local Sql Server. A script for the basic database is included

dotnet ef dbcontext scaffold "Server=.;Database=[DatabaseName];Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models -t Products
