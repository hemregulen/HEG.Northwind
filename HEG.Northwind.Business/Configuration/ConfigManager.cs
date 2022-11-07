using HEG.Northwind.Business.Configuration.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.Northwind.Business.Configuration
{
    public class ConfigManager : IConfigManager
    {
        private readonly IConfiguration IConfiguration;
        public ConfigManager(IConfiguration _IConfiguration)
        {
            this.IConfiguration = _IConfiguration;
        }
        private bool CacheControl(bool Status)
        {
            if (!Convert.ToBoolean(this.IConfiguration["CacheSystem:Status"]))
                return Convert.ToBoolean(this.IConfiguration["CacheSystem:Status"]);
            else
                return Status;
        }
        public CacheSystem CacheSystem => new CacheSystem
        {
            Status = Convert.ToBoolean(this.IConfiguration["CacheSystem:Status"]),
            CustomersCache=new CustomersCache
            {
                Minute = Convert.ToInt32(this.IConfiguration["CacheSystem:CustomersCache:Minute"]),
                Status = CacheControl(Convert.ToBoolean(this.IConfiguration["CacheSystem:CustomersCache:Status"]))
            }
        };
        public IConfigurationSection GetConfigurationSection(string Key)
        {
            return this.IConfiguration.GetSection(Key);
        }
    }
}
