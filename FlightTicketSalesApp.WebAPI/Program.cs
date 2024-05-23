using Autofac;
using Autofac.Extensions.DependencyInjection;
using FlightTicketSalesApp.Business.DependencyResolvers.Autofac;

var builder = WebApplication.CreateBuilder(args);

// Add hosts to the container.
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new AutofacBusinessModule());
    builder.RegisterModule(new AutofacAutoMapperModule());
});

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson
(
    options =>
    {
        options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
    }
);
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

app.UseAuthorization();

app.MapControllers();

app.Run();
