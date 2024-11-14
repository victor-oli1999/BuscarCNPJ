using BuscarCNPJ.Domain.Entities;
using BuscarCNPJ.Domain.Repository;
using BuscarCNPJ.Infra.Data;
using BuscarCNPJ.WebApi.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpClient<ICnpjRepository, CNPJRepository>(client =>
{
    client.BaseAddress = new Uri("https://open.cnpja.com/office/");
});


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
