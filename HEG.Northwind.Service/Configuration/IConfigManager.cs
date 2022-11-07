using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.Northwind.Service.Configuration
{
    public interface IConfigManager
    {
        string NorthwindURL { get; }
        IConfigurationSection GetConfigurationSection(string Key);
    }
}
