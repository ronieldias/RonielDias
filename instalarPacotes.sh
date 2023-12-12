#!/bin/bash

dotnet add package Microsoft.EntityFrameworkCore --version 6.0.1
dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.1
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 6.0.1
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.1
dotnet add package Pomelo.EntityFrameworkCore.MySql --version 6.0.1
dotnet add package Microsoft.EntityFrameworkCore.Relational --version 6.0.1
dotnet add package System.Configuration.ConfigurationManager --version 6.0.1
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 6.0.1
dotnet tool install --global dotnet-ef --version 6.0.1
dotnet tool install --global dotnet-aspnet-codegenerator --version 6.0.1

