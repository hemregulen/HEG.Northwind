using HEG.Northwind.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.Northwind.Core.DTO
{
    public class OrdersDTO
    {
        public List<Orders> listOfOrders{ get; set; }
        public Customers Customers { get; set; }
    }
}
