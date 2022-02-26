﻿/**
* Proyecto que incluye:
* Dependency Injection
* Logging (Serilog)
* Settings 
*/

using Microsoft.Extensions.Configuration;
using Serilog;
using System;
using System.IO;

#region MAIN

var builder = new ConfigurationBuilder();
BuildConfig(builder);

Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Build())
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .CreateLogger();

Log.Logger.Information("Application Starting");

#endregion


static void BuildConfig(IConfigurationBuilder builder)
{
    builder
        .SetBasePath(Directory
        .GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: true)
        .AddEnvironmentVariables();

}