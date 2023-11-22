using Microsoft.EntityFrameworkCore;
using Student.Application.Interfaces.RepositoryInterfaces;
using Student.Application.Interfaces.ServiceInterfaces;
using Student.Application.Services;
using Student.Domin.DataContext;
using Student.Domin.Repositories;

var builder = WebApplication.CreateBuilder(args);

// adding db configuration
builder.Services.AddDbContext<StudentDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register Service
builder.Services.AddScoped<IStudent, StudentService>();
builder.Services.AddScoped<ICourse, CourseService>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<ICourseRepository, CourseRepository>();

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
