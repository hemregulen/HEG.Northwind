using HEG.Northwind.Business.Configuration.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.Northwind.Business.Configuration
{
    public interface IConfigManager
    {
        CacheSystem CacheSystem { get; }
        IConfigurationSection GetConfigurationSection(string Key);
    }
}
