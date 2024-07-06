using Microsoft.EntityFrameworkCore;
using SchoolProject.Infrastructure.Abstracts;
using SchoolProject.Infrastructure.Data;
using SchoolProject.Infrastructure.Repositories;
using SchoolProject.Infrastructure;
using SchoolProject.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//connection to SqlServer
builder.Services.AddDbContext<ApplecationDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//Dependency Injection with use AddTransient
//builder.Services.AddScoped<IStudentRepository, StudentRepository>();
#region Dependency Injection with use AddTransient

builder.Services.AddInfrastructureDependencies()
                    .AddServiceDependencies();
#endregion


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
