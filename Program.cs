using Microsoft.EntityFrameworkCore;
using SuperMarketAPI.Data;
using SuperMarketAPI.service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ProductsDbContext>(Options => Options.UseNpgsql(builder.Configuration.GetConnectionString("ServerConnection")));
builder.Services.AddScoped<ProdutoService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();