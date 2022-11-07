using AutoWrapper.Wrappers;
using HEG.Northwind.Core.DTO;
using HEG.Northwind.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.Northwind.Business.OrdersBusiness.Interface
{
    public interface IOrdersBusiness
    {
        ApiResponse listOfOrdersJoin();
        ApiResponse listOfOrdersByCustomerId(string CustomerId);
        ApiResponse OrdersAdd(Orders Orders);
        ApiResponse OrdersUpdate(Orders Orders);
        ApiResponse OrdersDelete(Orders Orders);
        ApiResponse OrdersGet(int OrderID);
    }
}
