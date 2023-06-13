var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();


// TODO: give minimal APIs a go, ditch and go for controllers if it's too much effort