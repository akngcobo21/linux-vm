var builder = WebApplication.CreateBuilder(args);


builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(5000);
});

var app = builder.Build();

app.MapGet("/api/status", () => Results.Ok(new { Server = "Azure Linux VM", Status = "Online" }));

app.MapPost("/api/data", (MessageDto request) =>
{
    Console.WriteLine($"[Received from Windows]: {request.Text}");
    return Results.Ok(new { Response = $"Azure VM processed: '{request.Text}'" });
});

app.Run();

record MessageDto(string Text);
