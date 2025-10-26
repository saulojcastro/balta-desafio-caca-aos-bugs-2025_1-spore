using BugStore.Configs;

var builder = WebApplication.CreateBuilder(args);
UserSecretsConfiguration.AddUserSecretsConfiguration(builder);
DbContextConfiguration.AddDbContextConfiguration(builder);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
