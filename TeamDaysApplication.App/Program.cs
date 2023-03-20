using System.Reflection;
using TeamDaysApplication.Contracts.Requests;
using TeamDaysApplication.Domain.Models.FulfillmenttoolsApi;
using TeamDaysApplication.Domain.Models.FulfillmenttoolsApi.CreateOrder;
using TeamDaysApplication.Infrastructure.HttpClients;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add MediatR
builder.Services.AddMediatR(static config => config.RegisterServicesFromAssembly(Assembly.Load("TeamDaysApplication.Core")));

// Add AutoMapper
builder.Services.AddAutoMapper(config =>
{
    config.CreateMap<CreateShipFromStoreOrderConsumerAddressRequestContract, ConsumerAddress>();
    config.CreateMap<CreateShipFromStoreOrderConsumerRequestContract, CreateOrderConsumerModel>();
    config.CreateMap<CreateShipFromStoreOrderLineArticleRequestContract, OrderLineArticle>();
    config.CreateMap<CreateShipFromStoreOrderLineItemRequestContract, OrderLineItem>();
    config.CreateMap<CreateShipFromStoreOrderShippingRequestContract, Shipping>();
    config.CreateMap<CreateShipFromStoreOrderDeliveryPreferencesRequestContract, DeliveryPreferences>();
    config.CreateMap<CreateShipFromStoreOrderRequestContract, CreateShipFromStoreOrderRequestModel>();
});

// Add fulfillmenttools API Creds
var fulfillmenttoolsCreds =
    builder.Configuration.GetSection("fulfillmenttoolsCreds").Get<FulfillmenttoolsCredentials>();

builder.Services.AddSingleton(fulfillmenttoolsCreds!);

// Add HttpClients
builder.Services.AddSingleton(_ => new GoogleAuthApiClient());
builder.Services.AddSingleton(_ => new FulfillmenttoolsTeamDaysApiClient(builder.Configuration.GetValue<string>("fulfillmenttoolsCreds:Url")!));

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