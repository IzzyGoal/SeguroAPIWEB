using Microsoft.EntityFrameworkCore;
using SeguroWebApi.Domain;
using SeguroWebApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ClienteContext>( x => x.UseSqlServer("Server=DESKTOP-N3QI69B\\SQLEXPRESS;Database=model;Trusted_Connection=True;"));
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
