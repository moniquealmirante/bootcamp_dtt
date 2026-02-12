using Microsoft.EntityFrameworkCore;
using MinhaApi.Data; 
using StackExchange.Redis;
using MinhaApi.Queue;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();


builder.Services.AddDbContext<AppDbContext>(options =>
{
    var cs = builder.Configuration.GetConnectionString("DefaultConnection"); 
    options
        .UseNpgsql(cs)
        .UseSnakeCaseNamingConvention();
});


AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

builder.Services.AddControllers();


builder.Services.AddSingleton<IConnectionMultiplexer>(sp =>
{
    var cs = builder.Configuration["Redis:ConnectionString"]!;
    return ConnectionMultiplexer.Connect(cs);
});


// options da fila
builder.Services.Configure<RedisQueueOptions>(builder.Configuration.GetSection("Redis"));

//enfileira
builder.Services.AddSingleton<ILoteQueueProducer, LoteQueueProducer>();

//processa
builder.Services.AddHostedService<LoteQueueWorker>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();