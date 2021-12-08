using MultipleDbEf.Api.StartHelper;
using MultipleDbEf.Data;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEndPoints();
builder.Services.AddDbContexts(builder.Configuration);

WebApplication app = builder.Build();
app.MapEndPoints();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();