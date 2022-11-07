using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HEG.Northwind.Service.Configuration;
using HEG.Northwind.Service.Northwind.Base;
using HEG.Northwind.Service.Northwind.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace HEG.Northwind.Service.Extension
{
    public static class DbContextExtensions
    {
        public static IServiceCollection ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IOrdersService, OrdersService>();
            services.AddScoped<IConfigManager, ConfigManager>();
            return services;
        }
    }
}
