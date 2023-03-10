using BlazorExpenseTracker.Data;
using BlazorExpenseTracker.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ICategoryRepository,CategoryRepository>();
builder.Services.AddControllers();

//connection DB

SqlConfiguration SqlConnectionConfiguration = new(builder.Configuration.GetConnectionString("SqlConnection"));

builder.Services.AddSingleton(SqlConnectionConfiguration);

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
