using EmployeesWebAPI.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var securityKey = "abcdefghijklmnopqrstuvwxyz1234567890";
var ByteKey = Encoding.UTF8.GetBytes(securityKey);

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer= true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,

        ValidIssuer = "Tavant",
        ValidAudience = "Tavant",
        IssuerSigningKey = new SymmetricSecurityKey(ByteKey)

    }
);

builder.Services.AddAuthorization();

//Configure dependency injection for dbcontext
builder.Services.AddDbContext<EmployeeDBContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("conStr"));
});

//Configure dependency injection for dal layer
builder.Services.AddScoped<IEmployeeDataAccess, EmployeeDataAccess>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
