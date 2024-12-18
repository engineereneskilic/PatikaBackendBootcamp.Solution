using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using _12.week_PRATIK_CodeFirstRelation.Data;

var builder = WebApplication.CreateBuilder(args);

// Add DbContext with SQL Server configuration.
builder.Services.AddDbContext<PatikaSecondDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();
app.MapGet("/", () => "Code First Relation Project is Running!");
app.Run();