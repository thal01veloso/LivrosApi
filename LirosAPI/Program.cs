using livrariaApi.context;
using livrariaApi.models;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

      
builder.Services.AddControllers();
builder.Services.AddDbContext<LivroDbContext>(opt => opt.UseMySql(builder.Configuration.GetConnectionString("connectionString"), 
    new MySqlServerVersion(new Version(8, 0, 23))));                                    
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
