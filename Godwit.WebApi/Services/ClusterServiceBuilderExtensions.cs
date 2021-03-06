using Godwit.WebApi.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Godwit.Api.Services {
    public static class ClusterServiceBuilderExtensions {
        public static IServiceCollection AddClusterService(this IServiceCollection services) {
            services.AddSingleton<ClusterService>();
            services.AddSingleton<IHostedService>(_ => _.GetService<ClusterService>());
            services.AddSingleton(_ => _.GetService<ClusterService>().Client);
            return services;
        }
    }
}