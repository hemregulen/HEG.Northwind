using AutoWrapper.Wrappers;
using HEG.Northwind.Service.HttpClientService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.Northwind.Service.Northwind.Interface
{
    public interface ICustomerService : IHttpClientService<ApiResponse>
    {
        Task<ApiResponse> listOfCustomers();
    }
}
