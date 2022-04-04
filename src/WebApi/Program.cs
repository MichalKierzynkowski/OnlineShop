using WebApi;

Host.CreateDefaultBuilder()
    .ConfigureWebHostDefaults(builder => builder.UseStartup<Startup>())
    .Build()
    .Run();