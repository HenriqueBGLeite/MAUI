using AppTask.Api.Libraries.Emails;
using AppTask.Database;
using AppTask.Database.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Net;
using System.Net.Mail;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Banco
builder.Services.AddDbContext<AppTaskContext>();

// D.I.
builder.Services.AddScoped<IUserModelRepository, UserModelRepository>();
builder.Services.AddScoped<ITaskModelRepository, TaskModelRepository>();
builder.Services.AddScoped<SmtpClient>(options =>
{
    var smtpClient = new SmtpClient(configuration.GetValue<string>("Mail:ServerSMTPAddress"), configuration.GetValue<int>("Mail:ServerPort"));
    smtpClient.EnableSsl = configuration.GetValue<bool>("Mail:ServerSMTPEnableSSL");
    smtpClient.Credentials = new NetworkCredential(configuration.GetValue<string>("Mail:MailAddress"), configuration.GetValue<string>("Mail:MailPassword"));

    return smtpClient;
});
builder.Services.AddScoped<EmailAccessToken>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
