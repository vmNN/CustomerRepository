using Abstractions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository.Repositories;
using Service;

namespace KundeProgramUI;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        HostApplicationBuilder builder = Host.CreateApplicationBuilder();


        builder.Services.AddSingleton<ICustomerRepository, CustomerRepository>();
        builder.Services.AddSingleton<IAddressRepository, AddressRepository>();

        builder.Services.AddTransient<ICustomerService, CustomerService>();
        builder.Services.AddTransient<IAddressService, AddressService>();
        builder.Services.AddTransient<Form1>();

        var app = builder.Build();
        Application.Run(app.Services.GetRequiredService<Form1>());
        
        
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        // ApplicationConfiguration.Initialize();
        // Application.Run(new Form1());
    }
}