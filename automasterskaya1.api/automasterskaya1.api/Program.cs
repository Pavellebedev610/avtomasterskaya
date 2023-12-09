using Microsoft.EntityFrameworkCore;
using TimeTable207.Context.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var conString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContextFactory<AutomasterskayaContext.AutomasterskayaContext> (x => x.UseSqlServer(conString),ServiceLifetime.Scoped);
builder.Services.AddScoped<IAutomasterskayaContext>(x => x.GetRequiredService<AutomasterskayaContext.AutomasterskayaContext>());

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
