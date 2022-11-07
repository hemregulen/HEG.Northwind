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
    public class CustomersRepository : BaseRepository<Customers, DBContext>, ICustomersRepository
    {
    }
}
