using Microsoft.Extensions.DependencyInjection;
using Service.Interfaces;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class ServicesConfiguration
    {
        public static IServiceCollection AddServiceConfig(this IServiceCollection services)
        {
            services.AddTransient<IStudentServices, StudentServices>();
            return services;
        }
    }
}
