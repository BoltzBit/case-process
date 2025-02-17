using CaseProcess.Infra.Context;
using CaseProcess.Infra.Repositories;
using CaseProcess.Application.Features.Commands;
using CaseProcess.Application.Features.Queries;
using CaseProcess.Application.Services;
using CaseProcess.Application.Mappings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

if (connectionString is not null)
{
    builder.Services.AddApplicationDbContext(connectionString);
    //TODO ability middleware to exception
    //builder.Services.AddScoped((_) => new SqlConnectionProvider(connectionString));
}
else
{
    throw new Exception("Connection String not found");
}

builder.Services.AddScoped<ICompanyAreaRepository, CompanyAreaRepository>();
builder.Services.AddScoped<IProcessRepository, ProcessRepository>();

builder.Services.AddScoped<ICompanyAreaService, CompanyAreaService>();
builder.Services.AddScoped<IProcessService, ProcessService>();

builder.Services.AddAutoMapper(typeof(CompanyAreaMapping));

//Commands
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(CreateCompanyAreaCommandHandler).Assembly));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(CreateProcessCommandHandler).Assembly));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetAllCompanyAreaQueryHandler).Assembly));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetAllProcessQueryHandler).Assembly));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(o => o.AddPolicy("CorsPolicy", builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
