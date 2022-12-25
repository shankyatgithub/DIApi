using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIApi.DataServices
{
    public interface IDataService
    {
        public string GetProductData(string url);
    }
}