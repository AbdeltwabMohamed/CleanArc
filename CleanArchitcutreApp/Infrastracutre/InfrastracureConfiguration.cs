using Infrastracutre.Interfaces;
using Infrastracutre.Repos;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracutre
{
    public static class InfrastracureConfiguration
    {
        public static IServiceCollection AddInfraConfig(this IServiceCollection services)
        {
            
            services.AddTransient(typeof(IBaseRepositry<>),typeof(BaseRepositry<>));

            return services;
        }
    }
}
