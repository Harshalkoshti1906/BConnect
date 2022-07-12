using Bconnect.service.IService;
using Bconnect.service.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bconnect.Dependancy
{
    public static class Dependancies
    {
        public static IServiceCollection RegisterServiceDependencies(this IServiceCollection services)
        {
            #region Service
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IBusinessCardService, BusinessCardService>();
            #endregion

            return services;
        }
    }
}
