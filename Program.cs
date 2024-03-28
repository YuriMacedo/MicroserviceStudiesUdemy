using AutoMapper;
using GeekShopping.ProdutAPI.Config;
using GeekShopping.ProdutAPI.Model.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connection = builder.Configuration.GetConnectionString("MySqlConnection");

builder.Services.AddDbContext<MySqlContext>(options => options.
    UseMySql(connection, new MySqlServerVersion(new Version(8, 0, 0)))); //Verificar versão do my sql dps


IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
builder.Services.AddSingleton(mapper);
AutoMapper.ServiceCollectionExtensions.AddAutoMapper(builder.Services, AppDomain.CurrentDomain.GetAssemblies());


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
