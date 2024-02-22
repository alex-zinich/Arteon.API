using Arteon.Application;
using Arteon.Infrastructure.Context;
using Arteon.WebAPI.Extensions;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(MapProfile));
builder.Services.AddDbContext<HotelContext>(p => p.UseSqlServer(Environment.GetEnvironmentVariable("SQLConnection")));
builder.Services.AddDependencies();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().AllowCredentials());
});
builder.Services.AddControllers();

HotelContext context = builder.Services.BuildServiceProvider().GetRequiredService<HotelContext>();

DatabaseInit.InitDatabase(context);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.Run();
