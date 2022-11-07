using AutoWrapper.Wrappers;
using HEG.Northwind.Service.HttpClientService;
using HEG.Northwind.Service.Northwind.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.Northwind.Service.Northwind.Interface
{
    public interface IOrdersService : IHttpClientService<ApiResponse>
    {
        Task<ApiResponse> OrdersJoin();
        Task<ApiResponse> listOfOrdersByCustomerId(string CustomerId);
        Task<ApiResponse> OrdersGet(int OrderID);
        Task<ApiResponse> OrdersAdd(Orders Orders);
        Task<ApiResponse> OrdersUpdate(Orders Orders);
        Task<ApiResponse> OrdersDelete(Orders Orders);
    }
}
