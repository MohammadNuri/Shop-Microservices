using Microsoft.EntityFrameworkCore;
using Products.Api;
using Products.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceRegistery();

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
