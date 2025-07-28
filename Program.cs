var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World! Jason! It's working! WUHUUU!!!");

app.Run();
