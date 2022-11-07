using AutoWrapper.Wrappers;
using HEG.Northwind.Business.Configuration;
using HEG.Northwind.Business.OrdersBusiness.Interface;
using HEG.Northwind.Core.Entities;
using HEG.Northwind.Core.Repository.Interface;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HEG.Northwind.Business.OrdersBusiness.Base
{
    public class CustomerBusiness : ICustomerBusiness
    {
        ApiResponse ApiResponse = null;
        string path = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;

        private readonly IConfigManager IConfigManager;
        private readonly IMemoryCache IMemoryCache;

        private readonly IOrdersRepository IOrdersRepository;
        private readonly ICustomersRepository ICustomersRepository;
        public CustomerBusiness(IConfigManager _IConfigManager, IMemoryCache _IMemoryCache, IOrdersRepository _IOrdersRepository, ICustomersRepository ıCustomersRepository)
        {
            this.IConfigManager = _IConfigManager;
            this.IMemoryCache = _IMemoryCache;

            this.IOrdersRepository = _IOrdersRepository;
            this.ICustomersRepository = ıCustomersRepository;

            ApiResponse = new ApiResponse("", "", (int)HttpStatusCode.OK, path);
            ApiResponse.IsError = false;
        }
        public ApiResponse listOfCustomers()
        {
            ApiResponse = new ApiResponse("", "", (int)HttpStatusCode.OK, path);
            ApiResponse.IsError = false;
            try
            {
                ApiResponse.Result = ICustomersRepository.CacheGetList(IMemoryCache,IConfigManager.CacheSystem.CustomersCache.Minute, IConfigManager.CacheSystem.CustomersCache.Status);
            }
            catch (Exception ex)
            {
                ApiResponse.Result = ex.Message;
                ApiResponse.ResponseException = ex.Message;
                ApiResponse.Message = "İşlem sırasında exception hatası: " + ex.Message;
                ApiResponse.StatusCode = (int)HttpStatusCode.InternalServerError;
                ApiResponse.IsError = true;
            }
            return ApiResponse;
        }
    }
}
