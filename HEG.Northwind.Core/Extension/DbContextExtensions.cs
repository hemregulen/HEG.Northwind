using HEG.Northwind.Core.Repository.Base;
using HEG.Northwind.Core.Repository.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.Northwind.Core.Extension
{
    public static class DbContextExtensions
    {
        public static IServiceCollection ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<IOrdersRepository, OrdersRepository>();
            services.AddScoped<ICustomersRepository, CustomersRepository>();
            return services;
        }
    }
}
