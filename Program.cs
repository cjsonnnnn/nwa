var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://+:80");
var app = builder.Build();

app.MapGet("/", () => "Cihuyyy, icikiwir => Mima suka Jason sekali, selamanya. 🥰😤");

app.Run();