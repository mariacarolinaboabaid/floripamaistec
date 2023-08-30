using exerciciosAPI.ConnectionStringSingleton;
using exerciciosAPI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// String de conexão BD
ConnectionStringSingleton connectionStringInstanciacao = ConnectionStringSingleton.GerarInstancia();
string connectionString = connectionStringInstanciacao.ReturnConnection();
// Injeção de dependência do contexto 
builder.Services.AddDbContext<FichaContext>(options => options.UseSqlite(connectionString));



// Configuração do automapper
builder.Services.AddAutoMapper(typeof(Program));

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
