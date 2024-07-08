var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
//Test pipeline
app.UseHttpsRedirection();

app.MapGet("time/utc", () => Results.Ok(DateTime.UtcNow));

await app.RunAsync();
