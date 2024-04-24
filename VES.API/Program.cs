using Microsoft.EntityFrameworkCore;
using VES.API.Data;
using VES.API.Services;
using VES.API.Types.Interfaces;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddDbContext<VESDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("VESConnectionString")));

builder.Services.AddDbContext<CDSDBContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("CDSConnectionString")));
builder.Services.AddAutoMapper(typeof(Program).Assembly);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ILFManagementService, LFManagementService>();
builder.Services.AddScoped<INoticeService,NoticeService>();
builder.Services.AddScoped<IPastDueService, PastDueService>();
builder.Services.AddScoped<IDbAccess, DbAccess>();
/*builder.Services.AddScoped<DbAccess>(x => new DbAccess(connString ?? ""));*/


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
app.UseAuthorization();
app.MapControllers();
app.Run();
