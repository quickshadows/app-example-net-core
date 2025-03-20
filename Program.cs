var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseHttpsRedirection();

    return "Timeweb Cloud + .NET Core = ❤️";
});

app.Run();
