using AutoWrapper.Wrappers;
using HEG.Northwind.Business.OrdersBusiness.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HEG.Northwind.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerBusiness ICustomerBusiness;
        public CustomerController(ICustomerBusiness _ICustomerBusiness)
        {
            this.ICustomerBusiness = _ICustomerBusiness;
        }
        [HttpGet("listOfCustomers")]
        public ApiResponse listOfCustomers()
        {
            return ICustomerBusiness.listOfCustomers();
        }
    }
}
