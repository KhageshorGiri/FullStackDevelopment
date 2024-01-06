using Microsoft.EntityFrameworkCore;
using Serilog;
using Student.API.Middleware;
using Student.Application;
using Student.Application.Interfaces.RepositoryInterfaces;
using Student.Application.Interfaces.ServiceInterfaces;
using Student.Application.Services;
using Student.Domin.DataContext;
using Student.Domin.GenericClasses;
using Student.Domin.Repositories;
using Student.Entities.Entities;

var builder = WebApplication.CreateBuilder(args);

var logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .Enrich.FromLogContext()
    .CreateLogger();

try
{
    Log.Information("Starting web application");

    builder.Logging.ClearProviders();
    builder.Logging.AddSerilog(logger);

    // Adding db configuration
    builder.Services.AddDbContext<StudentDbContext>(options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
    });

    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    builder.Services.AddApplication();

    // Register Services
    builder.Services.AddScoped<IStudent, StudentService>();
    builder.Services.AddScoped<ICourse, CourseService>();
    builder.Services.AddScoped<IStudentRepository, StudentRepository>();
    builder.Services.AddScoped<ICourseRepository, CourseRepository>();
    builder.Services.AddScoped<IEnroll, Enrollservice>();
    //builder.Services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
    builder.Services.AddScoped<IEnrollRepository, EnrollRepository>();

    var app = builder.Build();

    app.UseMiddleware<GlobalExceptionHabdelerMiddleware>();

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();

    app.Run();
}
catch(Exception ex)
{
    Log.Fatal(ex, "Application terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}
