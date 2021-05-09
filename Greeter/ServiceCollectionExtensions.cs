using Greeter.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Greeter
{
    public static class ServiceCollectionExtensions
    {
        // This is an extension method.
        // For more information on extension methods visit: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
        public static IServiceCollection AddGreeter(this IServiceCollection services)
        {
            services.AddTransient<IGreeterService, GreeterService>();
            return services;
        }
    }
}
