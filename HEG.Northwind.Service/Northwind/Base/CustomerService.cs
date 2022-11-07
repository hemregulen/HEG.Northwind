using AutoWrapper.Wrappers;
using HEG.Northwind.Service.Configuration;
using HEG.Northwind.Service.HttpClientService;
using HEG.Northwind.Service.Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.Northwind.Service.Northwind.Base
{
    public class CustomerService : HttpClientService<ApiResponse>, ICustomerService
    {
        private readonly IConfigManager IConfigManager;
        public CustomerService(IConfigManager _IConfigManager)
        {
            this.IConfigManager = _IConfigManager;
        }
        public async Task<ApiResponse> listOfCustomers()
        {
            return await this.MethodGet(IConfigManager.NorthwindURL + "api/Customer/listOfCustomers");
        }
    }
}
