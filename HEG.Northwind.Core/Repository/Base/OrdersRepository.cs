using HEG.Northwind.Core.DTO;
using HEG.Northwind.Core.Entities;
using HEG.Northwind.Core.Repository.Context;
using HEG.Northwind.Core.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.Northwind.Core.Repository.Base
{
    public class OrdersRepository : BaseRepository<Orders, DBContext>, IOrdersRepository
    {
        private readonly ICustomersRepository ICustomersRepository;
        public OrdersRepository(ICustomersRepository _ICustomersRepository)
        {
            this.ICustomersRepository = _ICustomersRepository;
        }
        public List<OrdersDTO> listOfOrdersJoin()
        {
            return ICustomersRepository.GetList().GroupJoin(
                this.GetList(), Customers => 
                Customers.CustomerID, 
                orders => orders.CustomerID, 
                (customers,orders) => 
                new OrdersDTO
                {
                    listOfOrders = orders.ToList(),
                    Customers = customers
                }).ToList();
        }
    }
}
