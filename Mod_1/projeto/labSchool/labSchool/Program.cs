using System.Reflection;
using FluentValidation;
using FluentValidation.AspNetCore;
using labSchool.Context;
using labSchool.Models;
using labSchool.Repositories.Interfaces;
using labSchool.Repository;
using labSchool.Validators;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers().AddFluentValidation();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IValidator<Aluno>, AlunoValidator>();

// Injeção de dependência BD e repositórios
builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();
builder.Services.AddDbContext<LabSchoolContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("LabSchoolContext")));

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

