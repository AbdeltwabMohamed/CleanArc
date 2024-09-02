using Infrastracutre.Interfaces;
using Infrastracutre.Repos;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastracutre
{
    public static class InfrastracureConfiguration
    {
        public static IServiceCollection AddInfraConfig(this IServiceCollection services)
        {

            services.AddTransient(typeof(IBaseRepositry<>), typeof(BaseRepositry<>));
            services.AddTransient<IDepartmentRepositry, DepartmentRepositry>();

            return services;
        }
    }
}
