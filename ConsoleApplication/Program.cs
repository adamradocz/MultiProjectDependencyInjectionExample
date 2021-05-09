using Greeter;
using Greeter.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ClientApp
{
    class Program
    {
        private static IServiceProvider _serviceProvider;

        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();

            var greeterService = _serviceProvider.GetRequiredService<IGreeterService>();
            Console.WriteLine(greeterService.Greet());

            Console.WriteLine("Push a key to exit...");
            Console.ReadLine();
        }

        // Use this method to add services to the container.
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddGreeter();
        }
    }
}
