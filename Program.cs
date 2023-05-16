using Microsoft.EntityFrameworkCore;
using UzInfoComStudents.Core.Interface;
using UzInfoComStudents.Core;
using UzInfoComStudents.Data;
using FluentAssertions.Common;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


    builder.Services.AddDbContext<StudentDbContext>(options => options.UseSqlServer(
           builder.Configuration.GetConnectionString("Default"),
           builder => { builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null); }));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IStudentService, StudentService>();

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
