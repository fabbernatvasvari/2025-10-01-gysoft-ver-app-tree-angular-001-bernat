using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;
using MyApp.Backend.Context;
using MyApp.Backend.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddBackend();

builder.Services.AddCors(options =>
{
    options.AddPolicy("KretaCors",
            policy =>
            {
                policy.WithOrigins("http://localhost:4200")
                      .AllowAnyHeader()
                      .AllowAnyMethod();
            });
});

var app = builder.Build();

// InMemory database data
using (var scope = app.Services.CreateAsyncScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppInMemoryContext>();

    // InMemory test data
    try
    {
    dbContext.Database.EnsureCreated();
    } catch (System.InvalidOperationException)
    {
        Console.Error.WriteLine("System.InvalidOperationException: 'The seed entity for entity type 'Teacher' cannot be added because a default value was provided for the required property 'Id'. Please provide a value different from '00000000-0000-0000-0000-000000000000'.'");
    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Cors
app.UseCors("KretaCors"); // "AllowFrontendApp" vagy "AllowForeignOrigin" jobb név lenne a paraméternek

app.UseAuthorization();

app.MapControllers();

app.Run();
