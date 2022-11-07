using HEG.Northwind.Core.DTO;
using HEG.Northwind.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.Northwind.Core.Repository.Interface
{
    public interface IOrdersRepository : IRepository<Orders>
    {
        List<OrdersDTO> listOfOrdersJoin();
    }
}
