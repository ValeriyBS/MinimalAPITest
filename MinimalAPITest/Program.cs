using Microsoft.AspNetCore.Mvc;
using MinimalAPITest.Extensions;
using MinimalAPITest.Model;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddServices();

var app = builder.Build();

app.UseSwagger();
app.MapGet("/api/todo/all", async ([FromServices] IToDoItemRepository repository) =>
{
    return repository.GetAll();
});

app.MapGet("/api/todo/{id}", async ([FromServices] IToDoItemRepository repository, int id) =>
{
    return repository.GetById(id);
});

app.MapPost("/api/todo", async ([FromServices] IToDoItemRepository repository, ToDoItem item) =>
{
    repository.CreateNewToDoItem(item);
    return Results.Created($"/api/todo/{item.Id}", item);
});

app.UseSwaggerUI();

app.Run();
