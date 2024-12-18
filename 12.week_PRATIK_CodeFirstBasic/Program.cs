using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Add services to the container.
builder.Services.AddDbContext<PatikaFirstDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

app.MapGet("/", () => "Hello World!");

app.Run();
