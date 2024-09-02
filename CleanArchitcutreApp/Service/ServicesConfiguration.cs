using Microsoft.Extensions.DependencyInjection;
using Service.Interfaces;
using Service.Services;

namespace Service
{
    public static class ServicesConfiguration
    {
        public static IServiceCollection AddServiceConfig(this IServiceCollection services)
        {
            services.AddTransient<IStudentServices, StudentServices>();
            services.AddTransient<IDepartmentServices, DepartmentServices>();
            return services;
        }
    }
}
