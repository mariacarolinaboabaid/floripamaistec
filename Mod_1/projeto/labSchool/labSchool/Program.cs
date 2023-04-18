using System.Reflection;
using FluentValidation;
using FluentValidation.AspNetCore;
using labSchool.Context;
using labSchool.Models;
using labSchool.Repositories;
using labSchool.Repositories.Interfaces;
using labSchool.Validators;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// ADIÇÃO DO FLUENT VALIDATION
builder.Services.AddControllers()
             .AddFluentValidation(options =>
             {
                 // Validate child properties and root collection elements
                 options.ImplicitlyValidateChildProperties = true;
                 options.ImplicitlyValidateRootCollectionElements = true;

                 // Automatic registration of validators in assembly
                 options.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
             });


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddTransient<IValidator<Aluno>, AlunoValidator>();

// INJEÇÕES DE DEPENDÊNCIA DO BANCO DE DADOS E DOS REPOSITÓRIOS
builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();
builder.Services.AddScoped<IAtendimentoRepository, AtendimentoRepository>();
builder.Services.AddScoped<IPedagogoRepository, PedagogoRepository>();
builder.Services.AddScoped<IProfessorRepository, ProfessorRepository>();
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

