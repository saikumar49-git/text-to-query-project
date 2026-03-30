using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using ollama.infrastructure.DBContext;
try
{
    var builder = WebApplication.CreateBuilder(args);


    // Add services to the container.
    builder.Services.AddControllers();
    builder.Services.AddCors(options =>
    {
        options.AddPolicy("AllowAll", builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
    });
 builder.WebHost.ConfigureKestrel(o => o.Limits.MaxRequestBodySize = long.MaxValue);

 // Authentication - with the default credentials
 var azure_credentials = new DefaultAzureCredential(new DefaultAzureCredentialOptions());

 // Instance of the SecretClient class for the specified vault  
 var secretClient = new SecretClient(new Uri(builder.Configuration["KeyVault:VaultUrl"] ?? string.Empty), azure_credentials);

 // From the keyvault, obtain the EPPPS database settings
 var connectionString = secretClient.GetSecret(builder.Configuration["KeyVault:SQLDBConnection"]).Value.Value;
 var azureSAConnection = secretClient.GetSecret(builder.Configuration["KeyVault:AzureSAConnectionString"]).Value.Value;
  builder.Configuration["EPPPSSettings:ConnectionString"] = connectionString;
  builder.Configuration["EPPPSSettings:AzureSAConnection"] = azureSAConnection;
    // Configure EF Core with SQL Server

   builder.Services.AddDbContext<EPPPSDBContext>(options =>
       options.UseSqlServer(connectionString));

    // Configure Ollama HTTP Client
    builder.Services.AddHttpClient<ollama.Core.Interfaces.IOllamaService, ollama.infrastructure.Services.OllamaService>(client => 
    {
        client.BaseAddress = new Uri(builder.Configuration["OllamaSettings:BaseUrl"] ?? "http://localhost:11434/");
    });

    // Register Services
    builder.Services.AddScoped<ollama.Core.Interfaces.ISchemaExtractionService, ollama.infrastructure.Services.SchemaExtractionService>();
    builder.Services.AddScoped<ollama.Core.Interfaces.ISqlValidatorService, ollama.infrastructure.Services.SqlValidatorService>();
    builder.Services.AddScoped<ollama.Core.Interfaces.ISqlExecutionService, ollama.infrastructure.Services.SqlExecutionService>();
    builder.Services.AddScoped<ollama.Core.Interfaces.IQueryService, ollama.infrastructure.Services.QueryService>();
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
app.UseCors("AllowAll");
app.UseAuthorization();

app.MapControllers();

app.Run();
}
catch (Exception ex)
{
    Console.WriteLine($"Application startup failed: {ex}");
    throw;
}
finally
{
}