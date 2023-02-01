using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestXSIS.Data;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

// Add services to the container.
var ConnectionString = configuration.GetValue<string>("ConnectionStrings:Default");
builder.Services.AddDbContext<MysqlDBContext>(options => options.UseMySQL(ConnectionString));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressConsumesConstraintForFormFileParameters = true;
    options.SuppressInferBindingSourcesForParameters = true;
    options.SuppressModelStateInvalidFilter = true;
});

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
