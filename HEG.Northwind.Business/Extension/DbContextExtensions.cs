using HEG.Northwind.Business.Configuration;
using HEG.Northwind.Business.OrdersBusiness.Base;
using HEG.Northwind.Business.OrdersBusiness.Interface;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.Northwind.Business.Extension
{
    public static class DbContextExtensions
    {
        public static IServiceCollection ConfigureRepositories(this IServiceCollection services)
        {
            services = Core.Extension.DbContextExtensions.ConfigureRepositories(services);
            services.AddMemoryCache();
            services.AddScoped<IMemoryCache, MemoryCache>();
            services.AddScoped<IConfigManager, ConfigManager>();
            services.AddScoped<ICustomerBusiness, CustomerBusiness>();
            services.AddScoped<IOrdersBusiness, OrdersBusiness.Base.OrdersBusiness>();
            return services;
        }
    }
}
