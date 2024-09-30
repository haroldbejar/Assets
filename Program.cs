using AssetManagenetAPI;
using AssetManagenetAPI.Factory;

var builder = WebApplication.CreateBuilder(args);

var constring = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container
// builder.Services.AddAutoMapperConfig();
builder.Services.AddData(constring);
builder.Services.AddRepository();
builder.Services.AddServices();
builder.Services.AddFactoryConfig();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(opt => 
{
    opt.AddPolicy("AllowAll",
        builder => {
            builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();        
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().WithOrigins("*"));
app.UseHttpsRedirection();
app.MapControllers();
app.Run();



