using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.Northwind.Service.Configuration
{
    public class ConfigManager : IConfigManager
    {
        private readonly IConfiguration IConfiguration;
        public ConfigManager(IConfiguration _IConfiguration)
        {
            this.IConfiguration = _IConfiguration;
        }

        public string NorthwindURL => this.IConfiguration["URL:NorthwindURL"];

        public IConfigurationSection GetConfigurationSection(string Key)
        {
            return this.IConfiguration.GetSection(Key);
        }
    }
}
