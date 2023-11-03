using FileCreateWorkerService;
using FileCreateWorkerService.Services;
using RabbitMQ.Client;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        
        services.AddHostedService<Worker>();
        services.AddSingleton<RabbitMQClientService>();

        //services.AddSingleton(sp => new ConnectionFactory()
        //{
        //    Uri = new Uri(GetConnectionString("RabbitMQ")),
        //    DispatchConsumersAsync = true
        //});

    })
    .Build();

await host.RunAsync();
