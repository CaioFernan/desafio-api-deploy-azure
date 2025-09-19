using Microsoft.EntityFrameworkCore;
using projetoapi.Context;

var builder = WebApplication.CreateBuilder(args);

// DbContext
builder.Services.AddDbContext<RHContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao"))
);

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Habilita Swagger
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/index.html", "Minha API V1");
    c.RoutePrefix = "swagger";
});

// Middleware de redirecionamento confiável
app.Use(async (context, next) =>
{
    if (context.Request.Path == "/swagger")
    {
        context.Response.Redirect("/swagger/index.html");
        return;
    }
    await next();
});

// Endpoint raiz
app.MapGet("/", () => Results.Ok("API online 🚀"));


app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
