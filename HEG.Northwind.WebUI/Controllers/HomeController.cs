using AutoWrapper.Wrappers;
using HEG.Northwind.Service.Northwind.Interface;
using HEG.Northwind.Service.Northwind.Model;
using HEG.Northwind.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net;

namespace HEG.Northwind.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICustomerService ICustomerService;

        public HomeController(ILogger<HomeController> logger, ICustomerService _ICustomerService)
        {
            this.ICustomerService = _ICustomerService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        //[CustomAuthorize]
        public async Task<JsonResult> listOfCustomers()
        {
            ApiResponse apiResponse = new ApiResponse("", "", (int)HttpStatusCode.OK);
            try
            {
                apiResponse = await ICustomerService.listOfCustomers();
                apiResponse.Result = JsonConvert.DeserializeObject<List<Customers>>(apiResponse.Result.ToString());
            }
            catch (Exception ex)
            {
                apiResponse.ResponseException = ex;
                apiResponse.Message = ex.Message;
                apiResponse.IsError = true;
            }
            return Json(apiResponse);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}