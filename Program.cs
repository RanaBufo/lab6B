var builder = WebApplication.CreateBuilder();
var app = builder.Build();

builder.Configuration.AddJsonFile("config.json");
builder.Configuration.AddXmlFile("config.xml");
builder.Configuration.AddIniFile("config.ini");

app.Map("/", (IConfiguration appConfig) => $"{appConfig["person"]} - {appConfig["company"]} {appConfig["person1"]} - {appConfig["company1"]} {appConfig["person2"]} - {appConfig["company2"]}");

app.Run();