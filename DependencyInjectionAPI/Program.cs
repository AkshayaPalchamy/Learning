using DependencyInjectionAPI;
using static DependencyInjectionAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<DependencyInjectionAPI.ICategoryRepository, DependencyInjectionAPI.CategoryRepository>();


builder.Services.AddTransient<IServices.ITransientService,TestServices.MyService>();
builder.Services.AddScoped<IServices.IScopedService, TestServices.MyService>();
builder.Services.AddSingleton<IServices.ISingletonService, TestServices.MyService>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
