using Microsoft.EntityFrameworkCore;
using VES.API.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<VESDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("VESConnectionString")));
builder.Services.AddCors(options =>

{

    options.AddDefaultPolicy(builder =>

    {

        builder.AllowAnyOrigin()

               .AllowAnyMethod()

               .AllowAnyHeader();

    });

});

var app = builder.Build();
app.UseCors();

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
