var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var ver= "1.1.9";
var calc= 2+1000;
var calc2= 2+999;

var feature_2 = "Super best code";

string feature_1 = "New feature";


string feature_100 = "New feature 100";

string feature_200 = "New feature 200";

string feature_300 = "New feature 300";

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
