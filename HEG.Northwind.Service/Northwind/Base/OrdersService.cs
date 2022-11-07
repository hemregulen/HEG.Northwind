using AutoWrapper.Wrappers;
using HEG.Northwind.Service.HttpClientService;
using HEG.Northwind.Service.Northwind.Interface;
using HEG.Northwind.Service.Northwind.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.Northwind.Service.Northwind.Base
{
    public class OrdersService : HttpClientService<ApiResponse>, IOrdersService
    {
        public Task<ApiResponse> listOfOrdersByCustomerId(string CustomerId)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> OrdersAdd(Orders Orders)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> OrdersDelete(Orders Orders)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> OrdersGet(int OrderID)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> OrdersJoin()
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> OrdersUpdate(Orders Orders)
        {
            throw new NotImplementedException();
        }
    }
}
