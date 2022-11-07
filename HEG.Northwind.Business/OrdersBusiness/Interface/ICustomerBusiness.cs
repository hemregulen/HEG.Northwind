using AutoWrapper.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.Northwind.Business.OrdersBusiness.Interface
{
    public interface ICustomerBusiness
    {
        ApiResponse listOfCustomers();
    }
}
