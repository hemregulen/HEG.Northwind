using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.Northwind.Business.Configuration.Model
{
    public class CacheSystem
    {
        public bool Status { get; set; }
        public CustomersCache CustomersCache { get; set; }
    }
}
