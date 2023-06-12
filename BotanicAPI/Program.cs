using BotanicAPI.DataContext;
using BotanicAPI.Repositories.MilestoneRepository.Implements;
using BotanicAPI.Repositories.MilestoneRepository.Interfaces;
using BotanicAPI.Repositories.ProfileRepository.Implements;
using BotanicAPI.Repositories.ProfileRepository.Interfaces;
using BotanicAPI.Repositories.RouteRepository.Implements;
using BotanicAPI.Repositories.RouteRepository.Interfaces;
using BotanicAPI.Repositories.UserRepository.Implements;
using BotanicAPI.Repositories.UserRepository.Interfaces;
using BotanicAPI.Services.Implements;
using BotanicAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add Services
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IRouteService, RouteService>();


//Add Repositories
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IProfileRepository, ProfileRepository>();
builder.Services.AddScoped<IMilestonesRepository, MilestonesRepository>();
builder.Services.AddScoped<IRouteRepository, RouteRepository>();

//Context DataBase
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder => builder
       .AllowAnyHeader()
       .AllowAnyMethod()
       .AllowAnyOrigin());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
