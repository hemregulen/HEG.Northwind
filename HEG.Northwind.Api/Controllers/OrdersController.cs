using AutoWrapper.Wrappers;
using HEG.Northwind.Business.OrdersBusiness.Interface;
using HEG.Northwind.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HEG.Northwind.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersBusiness IOrdersBusiness;
        public OrdersController(IOrdersBusiness _IOrdersBusiness)
        {
            this.IOrdersBusiness = _IOrdersBusiness;
        }
        
        [HttpGet("listOfOrdersByCustomerId/{CustomerId}")]
        public ApiResponse listOfOrdersByCustomerId(string CustomerId)
        {
            return IOrdersBusiness.listOfOrdersByCustomerId(CustomerId);
        }
        [HttpGet("OrdersJoin")]
        public ApiResponse OrdersJoin()
        {
            return IOrdersBusiness.listOfOrdersJoin();
        }
        [HttpGet("OrdersGet/{OrderID}")]
        public ApiResponse OrdersGet(int OrderID)
        {
            return IOrdersBusiness.OrdersGet(OrderID);
        }
        [HttpPost("OrdersAdd")]
        public ApiResponse OrdersAdd(Orders Orders)
        {
            return IOrdersBusiness.OrdersAdd(Orders);
        }
        [HttpPost("OrdersUpdate")]
        public ApiResponse OrdersUpdate(Orders Orders)
        {
            return IOrdersBusiness.OrdersUpdate(Orders);
        }
        [HttpPost("OrdersDelete")]
        public ApiResponse OrdersDelete(Orders Orders)
        {
            return IOrdersBusiness.OrdersDelete(Orders);
        }
    }
}
