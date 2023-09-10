using Vecc.TriggerGitHubFlow.Services.Internal;
using Vecc.TriggerGitHubFlow.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ITrigger, DefaultTrigger>();

var app = builder.Build();

app.MapControllers();

app.Run();