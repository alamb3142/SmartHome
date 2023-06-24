using Api.Common;
using Application.Common;
using Application.Devices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApplicationServices();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => "Hello World!");


var devices = app.MapGroup("/devices").WithOpenApi();
devices.MediatePost<PairDeviceCommand, string>("/pair");
devices.MediateGet<GetDevicesQuery, List<DeviceDetailsResponse>>("/list");

app.Run();


// TODO: give minimal APIs a go, ditch and go for controllers if it's too much effort