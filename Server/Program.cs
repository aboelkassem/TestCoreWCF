using Server.Services;

var builder = WebApplication.CreateBuilder();

// Add WSDL support
builder.Services.AddServiceModelServices();
builder.Services.AddServiceModelMetadata();
// Use the scheme/host/port used to fetch WSDL as that service endpoint address in generated WSDL 
builder.Services.AddSingleton<IServiceBehavior, UseRequestHeadersForMetadataAddressBehavior>();

var app = builder.Build();

app.UseServiceModel(serviceBuilder =>
{
    serviceBuilder.AddService<EmployeeService>();
    serviceBuilder
        .AddServiceEndpoint<EmployeeService, IEmployeeService>(new BasicHttpBinding(), "/EmployeeService.svc")
        .AddServiceEndpoint<EmployeeService, IEmployeeService>(new BasicHttpBinding(BasicHttpSecurityMode.Transport), "/EmployeeService.svc");

    // Enable WSDL for http & https
    var serviceMetadataBehavior = app.Services.GetRequiredService<ServiceMetadataBehavior>();
    serviceMetadataBehavior.HttpsGetEnabled = true;
});

app.Run();
