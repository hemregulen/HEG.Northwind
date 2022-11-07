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
    public class OrdersBusiness: IOrdersBusiness
    {
        ApiResponse ApiResponse = null;
        string path = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;

        private readonly IConfigManager IConfigManager;
        private readonly IMemoryCache IMemoryCache;

        private readonly IOrdersRepository IOrdersRepository;
        private readonly ICustomersRepository ICustomersRepository;
        public OrdersBusiness( IConfigManager _IConfigManager, IMemoryCache _IMemoryCache, IOrdersRepository _IOrdersRepository, ICustomersRepository ıCustomersRepository)
        {
            this.IConfigManager = _IConfigManager;
            this.IMemoryCache = _IMemoryCache;

            this.IOrdersRepository = _IOrdersRepository;
            this.ICustomersRepository = ıCustomersRepository;

            ApiResponse = new ApiResponse("", "", (int)HttpStatusCode.OK, path);
            ApiResponse.IsError = false;
        }

        public ApiResponse listOfOrdersJoin()
        {
            ApiResponse = new ApiResponse("", "", (int)HttpStatusCode.OK, path);
            ApiResponse.IsError = false;
            try
            {
                ApiResponse.Result = IOrdersRepository.listOfOrdersJoin();
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

        public ApiResponse OrdersAdd(Orders Orders)
        {
            ApiResponse = new ApiResponse("", "", (int)HttpStatusCode.OK, path);
            ApiResponse.IsError = false;
            try
            {
                IOrdersRepository.Add(Orders);
                ApiResponse.Result = Orders;
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

        public ApiResponse OrdersUpdate(Orders Orders)
        {
            ApiResponse = new ApiResponse("", "", (int)HttpStatusCode.OK, path);
            ApiResponse.IsError = false;
            try
            {
                IOrdersRepository.Update(Orders);
                ApiResponse.Result = Orders;
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

        public ApiResponse OrdersDelete(Orders Orders)
        {
            ApiResponse = new ApiResponse("", "", (int)HttpStatusCode.OK, path);
            ApiResponse.IsError = false;
            try
            {
                IOrdersRepository.Delete(Orders);
                ApiResponse.Result = Orders;
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

        public ApiResponse OrdersGet(int OrderID)
        {
            ApiResponse = new ApiResponse("", "", (int)HttpStatusCode.OK, path);
            ApiResponse.IsError = false;
            try
            {
                ApiResponse.Result=IOrdersRepository.Get(x=>x.OrderID==OrderID);
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

        public ApiResponse listOfOrdersByCustomerId(string CustomerId)
        {
            ApiResponse = new ApiResponse("", "", (int)HttpStatusCode.OK, path);
            ApiResponse.IsError = false;
            try
            {
                ApiResponse.Result = IOrdersRepository.GetList(x => x.CustomerID == CustomerId);
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
