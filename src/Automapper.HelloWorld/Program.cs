using System;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Automapper.HelloWorld
{
    public static class Program
    {
        private static void Main()
        {
            var provider = new ServiceCollection()
                .ConfigureServices()
                .BuildServiceProvider();

            using var scope = provider.CreateScope();
            RunApp(scope.ServiceProvider);
        }

        private static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddAutoMapper(MapperExtensions.ConfigureMapper);
            return services;
        }

        private static void RunApp(IServiceProvider provider)
        {
            var mapper = provider.GetRequiredService<IMapper>();
            var a = new A();
            var b = mapper.Map<B>(a);
        }
    }
}