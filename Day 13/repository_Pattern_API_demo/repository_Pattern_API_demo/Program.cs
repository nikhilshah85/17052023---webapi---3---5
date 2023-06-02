using repository_Pattern_API_demo.Models;
using repository_Pattern_API_demo.Models.Repositories.MongoDB;
using repository_Pattern_API_demo.Models.Repositories.Oracle_Datasource;
using repository_Pattern_API_demo.Models.Repositories.SQL_DataSource;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IProducts, MongodataSource>();

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
