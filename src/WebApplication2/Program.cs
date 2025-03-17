using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Test Web API 2",
        Description = "A simple example ASP.NET Core Web API",
        Contact = new OpenApiContact
        {
            Name = "Maggie Crocamo",
            Email = "mjcrocamo@gmail.com"
        }
    });
});
builder.Services.AddControllers();

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints => endpoints.MapControllers());

// Configure the HTTP request pipeline.
// http://localhost:8085/swagger/index.html
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Test Api V2");
});

app.UseHttpsRedirection();

app.Run();