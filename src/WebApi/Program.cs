using Serilog;
using WebApi;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateBootstrapLogger();

try
{
    Log.Information("Starting service");
    Host.CreateDefaultBuilder()
        .UseSerilog((context, services, configuration) => configuration
            .ReadFrom.Configuration(context.Configuration)
            .ReadFrom.Services(services)
            .Enrich.FromLogContext()
            .WriteTo.Console())
        .ConfigureWebHostDefaults(builder => builder.UseStartup<Startup>())
        .Build()
        .Run();
}
catch (Exception e)
{
    Log.Fatal(e, "An unhandled exception occured during bootstrapping");
    return 1;
}
finally
{
    Log.CloseAndFlush();
}