var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

//routing 

// "/shirts"

app.MapGet("/shirts", () =>
{
    return "Reading all the shirts";
});

app.MapGet("/shirts/{id}", (int id) =>
{
    return $"Reading shirt with id: {id}";
});

app.MapPost("/shirts", () =>
{
    return "Creating a new shirt";
});

app.MapPut("/shirts/{id}", (int id) =>
{
    return $"Updating shirt with ID: {id}";
});

app.MapDelete("/shirts/{id}", (int id) =>
{
    return $"Deleting shirt with ID: {id}";
});

app.UseHttpsRedirection();



app.Run();

