using DIApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddScoped<IDataRepo, NoSqlDataRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    //app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/getData", (IDataRepo repo) =>
{
    //var repo = new NoSqlDataRepo();

    return Results.Ok(repo.ReturnData());
});

app.Run();